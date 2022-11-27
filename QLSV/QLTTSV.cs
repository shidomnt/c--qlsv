using Microsoft.Data.SqlClient;
using QLSV.Controllers;
using QLSV.Models;
using System.Data;

namespace QLSV
{
    internal partial class QLTTSV : Form
    {
        private SinhVienModel _sinhVienFormInput = new();
        private SinhVienModel sinhVienFormInput
        {
            get { return _sinhVienFormInput; }
            set
            {
                _sinhVienFormInput = value;
                txt_hoVaTenBox.Text = this.sinhVienFormInput.hoSV + ' ' + this.sinhVienFormInput.tenSV;
                txt_maSVBox.Text = this.sinhVienFormInput.maSV;
                txt_diaChiBox.Text = this.sinhVienFormInput.diaChi;
                txt_noiSinhBox.Text = this.sinhVienFormInput.noiSinh;
                txt_ngaySinhBox.Value = Convert.ToDateTime(this.sinhVienFormInput.ngaySinh);
                txt_maNganhBox.Text = this.sinhVienFormInput.maNganh;
                txt_gioiTinhNamRadio.Checked = this.sinhVienFormInput.gioiTinh == 1;
                txt_gioiTinhNuRadio.Checked = this.sinhVienFormInput.gioiTinh == 0;
            }
        }
        SqlDataAdapter adapter = new();
        DataTable sinhVienTable = new();
        private SinhVienController sinhVienController;
        public QLTTSV(SinhVienController controller)
        {
            InitializeComponent();
            sinhVienFormInput = new();
            sinhVienController = controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = Database.GetDB();
            adapter.SelectCommand = new SqlCommand("select * from SinhVien", db.connection);
            adapter.Fill(sinhVienTable);
            dataDSSinhVien.DataSource = sinhVienTable;
            foreach (var i in Enumerable.Range(0, sinhVienTable.Columns.Count))
            {
                dataDSSinhVien.Columns[i].Width = (dataDSSinhVien.Width - 42) / sinhVienTable.Columns.Count;
            }
        }
        private void txt_addBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            sinhVienController.Insert(sinhVienFormInput);
            Program.ShowInfomation("Thêm sinh viên thành công!");
            RefetchDataTable();
        }

        private void txt_updateBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            sinhVienController.Update(sinhVienFormInput);
            Program.ShowInfomation("Sửa sinh viên thành công!");
            RefetchDataTable();
        }

        private void txt_deleteBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            sinhVienController.Delete(sinhVienFormInput);
            Program.ShowInfomation("Xóa sinh viên thành công!");
            RefetchDataTable();
            if (sinhVienTable.Rows.Count == 0)
            {
                txt_fromRefreshBtn.PerformClick();
            }
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
            RadioButton? btn = sender as RadioButton;
            if (btn == null)
            {
                Program.ShowError(new Exception("sender is not a radio btn"));
                return;
            }
            if (btn.Checked)
            {
                string btnText = btn.Text;
                switch (btnText)
                {
                    case "Nam":
                        sinhVienFormInput.gioiTinh = 1;
                        break;
                    case "Nữ":
                        sinhVienFormInput.gioiTinh = 0;
                        break;
                    default:
                        break;
                }
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
            var result = ExtractRowFromSelectedRowDataGridView(sdr);
            if (result != null)
            {
                sinhVienFormInput = result;
            }
        }

        private void txt_fromRefreshBtn_Click(object sender, EventArgs e)
        {
            sinhVienFormInput = new();
        }
        private void RefetchDataTable()
        {
            sinhVienTable.Clear();
            adapter.Fill(sinhVienTable);
        }

        private void ExtractInputFromForm()
        {
            var hoTenSV = new Stack<string>(txt_hoVaTenBox.Text.Split(' '));
            sinhVienFormInput.maSV = txt_maSVBox.Text;
            sinhVienFormInput.tenSV = hoTenSV.Pop();
            sinhVienFormInput.hoSV = string.Join(' ', hoTenSV.ToArray().Reverse());
            sinhVienFormInput.diaChi = txt_diaChiBox.Text;
            sinhVienFormInput.noiSinh = txt_noiSinhBox.Text;
            sinhVienFormInput.ngaySinh =
                txt_ngaySinhBox.Value;
            sinhVienFormInput.maNganh = txt_maNganhBox.Text;
        }

        private SinhVienModel? ExtractRowFromSelectedRowDataGridView(DataGridView view)
        {
            int? currentIndex = view.CurrentCell?.RowIndex;
            if (currentIndex == null)
            {
                return null;
            }
            var maSV = Convert.ToString(sinhVienTable.Rows[(int)currentIndex]["MASV"]);
            var hoSV = Convert.ToString(sinhVienTable.Rows[(int)currentIndex]["HOSV"]);
            var tenSV = Convert.ToString(sinhVienTable.Rows[(int)currentIndex]["TENSV"]);
            var diaChi = Convert.ToString(sinhVienTable.Rows[(int)currentIndex]["DIACHI"]);
            var noiSinh = Convert.ToString(sinhVienTable.Rows[(int)currentIndex]["NOISINH"]);
            var gioiTinh = Convert.ToInt32(sinhVienTable.Rows[(int)currentIndex]["GIOITINH"]);
            var ngaySinh = Convert.ToDateTime(sinhVienTable.Rows[(int)currentIndex]["NGAYSINH"]);
            var maNganh = Convert.ToString(sinhVienTable.Rows[(int)currentIndex]["MANGANH"]);
            return new(maSV, hoSV, tenSV, diaChi, noiSinh, gioiTinh, ngaySinh, maNganh);
        }

    }
}