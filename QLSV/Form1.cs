using Microsoft.Data.SqlClient;
using QLSV.Controllers;
using QLSV.Models;
using System.Data;

namespace QLSV
{
    public partial class Form1 : Form
    {
        private SinhVienModel sinhVienFormInput = new();
        SqlDataAdapter adapter = new();
        DataTable sinhVienTable = new();
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = Database.GetDB();
            adapter.SelectCommand = new SqlCommand("select * from SinhVien", db.connection);
            adapter.Fill(sinhVienTable);
            dataDSSinhVien.DataSource = sinhVienTable;
            foreach (var i in Enumerable.Range(0, sinhVienTable.Columns.Count))
            {
                dataDSSinhVien.Columns[i].Width = (dataDSSinhVien.Width - 60) / sinhVienTable.Columns.Count;
            }
        }

        private void txt_addBtn_Click(object sender, EventArgs e)
        {
            ExtractInputFromForm();
            var db = Database.GetDB();
            SinhVienController sinhVienC = new(db);
            sinhVienC.Insert(sinhVienFormInput);
            sinhVienTable.Clear();
            adapter.Fill(sinhVienTable);
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
                        MessageBox.Show(btn.Text);
                        sinhVienFormInput.gioiTinh = 1;
                        break;
                    case "Nữ":
                        MessageBox.Show(btn.Text);
                        sinhVienFormInput.gioiTinh = 0;
                        break;
                    default:
                        break;
                }
            }
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
                txt_ngaySinhBox.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            sinhVienFormInput.maNganh = txt_maNganhBox.Text;
        }
    }
}