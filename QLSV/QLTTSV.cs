using Microsoft.EntityFrameworkCore;
using QLSV.EF.Contexts;
using QLSV.EF.Models;
using System.Data;

namespace QLSV
{
    internal partial class QLTTSV : Form
    {
        private SinhVien SinhVienFormState
        {
            get;
            set;
        }
        public QlsvContext Context { get; }
        public QLTTSV(QlsvContext context)
        {
            InitializeComponent();
            Context = context;
            SinhVienFormState = new();
            SyncStateAndForm();
        }

        private async void FormQLTTSV_Load(object sender, EventArgs e)
        {
            try
            {
                await Context.SinhViens.LoadAsync();
                dataDSSinhVien.DataSource = Context.SinhViens.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex, "Loi khi ket noi Database");
                Application.Exit();
            }
        }
        private async void txt_addBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            Context.ChangeTracker.Clear();
            Context.SinhViens.Add(SinhVienFormState);
            await SaveChangesAsync();
        }

        private async void txt_updateBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            Context.ChangeTracker.Clear();
            Context.SinhViens.Update(SinhVienFormState);
            await SaveChangesAsync();

        }

        private async void txt_deleteBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            Context.ChangeTracker.Clear();
            Context.SinhViens.Remove(SinhVienFormState);
            await SaveChangesAsync();

        }
        private void txt_exitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void txt_gioiTinhRadio_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(SinhVienFormState.Gioitinh);
            RadioButton? btn = sender as RadioButton;
            if (btn == null)
            {
                Program.ShowError(new Exception("sender is not a radio btn"));
                return;
            }
            if (btn.Checked)
            {
                SinhVienFormState.Gioitinh = btn.Text switch
                {
                    "Nam" => 1,
                    "Nữ" => 0,
                    _ => 1
                };
            }
        }

        private void dataDSSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView? sdr = sender as DataGridView;
            if (sdr == null)
            {
                Program.ShowError(new Exception("sender is not a data grid view"));
                return;
            }
            var result = ExtractDataFromSelectedRowDataGridView(sdr);
            if (result != null)
            {
                SinhVienFormState = result;
                SyncStateAndForm();
            }
        }

        private void txt_fromRefreshBtn_Click(object sender, EventArgs e)
        {
            SinhVienFormState = new();
        }
        private async Task<int> SaveChangesAsync()
        {
            try
            {
                var result = await Context.SaveChangesAsync();
                await Context.SinhViens.LoadAsync();
                dataDSSinhVien.DataSource = Context.SinhViens.Local.ToBindingList();
                return result;
            }
            catch (Exception ex)
            {
                Program.ShowError(ex, "Loi khi cap nhat du lieu den DB");
                return 0;
            }
        }

        private void SyncStateAndForm()
        {
            txt_hoVaTenBox.Text = SinhVienFormState.Hosv + ' ' + SinhVienFormState.Tensv;
            txt_maSVBox.Text = SinhVienFormState.Masv;
            txt_diaChiBox.Text = SinhVienFormState.Diachi;
            txt_noiSinhBox.Text = SinhVienFormState.Noisinh;
            txt_ngaySinhBox.Value = SinhVienFormState.Ngaysinh;
            txt_maNganhBox.Text = SinhVienFormState.Manganh.ToString();
            txt_gioiTinhNamRadio.Checked = SinhVienFormState.Gioitinh == 1;
            txt_gioiTinhNuRadio.Checked = SinhVienFormState.Gioitinh == 0;
        }

        private void ExtractInputFromForm()
        {
            var hoTenSV = new Stack<string>(txt_hoVaTenBox.Text.Split(' '));
            var tenSv = hoTenSV.Pop();
            var hoSv = string.Join(' ', hoTenSV.ToArray().Reverse());
            SinhVien sinhVien = new()
            {
                Masv = txt_maSVBox.Text,
                Hosv = hoSv,
                Tensv = tenSv,
                Diachi = txt_diaChiBox.Text,
                Noisinh = txt_noiSinhBox.Text,
                Ngaysinh = txt_ngaySinhBox.Value,
                Manganh = Convert.ToInt32(txt_maNganhBox.Text),
            };
            SinhVienFormState = sinhVien;
        }

        private SinhVien? ExtractDataFromSelectedRowDataGridView(DataGridView view)
        {
            int? currentIndex = view.CurrentCell?.RowIndex;
            if (currentIndex == null)
            {
                return null;
            }
            var maSV = dataDSSinhVien.Rows[(int)currentIndex].Cells["MaSV"].Value.ToString();
            var sinhVien = Context.SinhViens.Where(sinhvien => sinhvien.Masv == maSV);
            return sinhVien.Any() ? sinhVien.First() : null;
        }

    }
}