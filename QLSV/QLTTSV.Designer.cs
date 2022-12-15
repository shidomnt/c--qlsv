namespace QLSV
{
    partial class QLTTSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataDSSinhVien = new System.Windows.Forms.DataGridView();
            this.txt_exitBtn = new System.Windows.Forms.Button();
            this.txt_deleteBtn = new System.Windows.Forms.Button();
            this.txt_updateBtn = new System.Windows.Forms.Button();
            this.txt_addBtn = new System.Windows.Forms.Button();
            this.txt_gioiTinhNuRadio = new System.Windows.Forms.RadioButton();
            this.txt_gioiTinhNamRadio = new System.Windows.Forms.RadioButton();
            this.txt_gioiTinh = new System.Windows.Forms.Label();
            this.txt_ngaySinhBox = new System.Windows.Forms.DateTimePicker();
            this.txt_diaChiBox = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.Label();
            this.txt_hoVaTenBox = new System.Windows.Forms.TextBox();
            this.txt_ngaySinh = new System.Windows.Forms.Label();
            this.txt_noiSinhBox = new System.Windows.Forms.TextBox();
            this.txt_maNganhBox = new System.Windows.Forms.TextBox();
            this.txt_maSVBox = new System.Windows.Forms.TextBox();
            this.txt_noiSinh = new System.Windows.Forms.Label();
            this.txt_maNganh = new System.Windows.Forms.Label();
            this.txt_hoVaTen = new System.Windows.Forms.Label();
            this.txt_maSV = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSinhVien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDSSinhVien
            // 
            this.dataDSSinhVien.AllowUserToAddRows = false;
            this.dataDSSinhVien.AllowUserToDeleteRows = false;
            this.tableLayoutPanel1.SetColumnSpan(this.dataDSSinhVien, 3);
            this.dataDSSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDSSinhVien.Location = new System.Drawing.Point(3, 343);
            this.dataDSSinhVien.MultiSelect = false;
            this.dataDSSinhVien.Name = "dataDSSinhVien";
            this.dataDSSinhVien.ReadOnly = true;
            this.dataDSSinhVien.RowTemplate.Height = 25;
            this.dataDSSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDSSinhVien.Size = new System.Drawing.Size(764, 159);
            this.dataDSSinhVien.TabIndex = 2;
            this.dataDSSinhVien.SelectionChanged += new System.EventHandler(this.dataDSSinhVien_SelectionChanged);
            // 
            // txt_exitBtn
            // 
            this.txt_exitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_exitBtn.Location = new System.Drawing.Point(345, 3);
            this.txt_exitBtn.Name = "txt_exitBtn";
            this.txt_exitBtn.Size = new System.Drawing.Size(108, 38);
            this.txt_exitBtn.TabIndex = 3;
            this.txt_exitBtn.Text = "Thoát";
            this.txt_exitBtn.UseVisualStyleBackColor = true;
            this.txt_exitBtn.Click += new System.EventHandler(this.txt_exitBtn_Click);
            // 
            // txt_deleteBtn
            // 
            this.txt_deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_deleteBtn.Location = new System.Drawing.Point(231, 3);
            this.txt_deleteBtn.Name = "txt_deleteBtn";
            this.txt_deleteBtn.Size = new System.Drawing.Size(108, 38);
            this.txt_deleteBtn.TabIndex = 2;
            this.txt_deleteBtn.Text = "Xóa";
            this.txt_deleteBtn.UseVisualStyleBackColor = true;
            this.txt_deleteBtn.Click += new System.EventHandler(this.txt_deleteBtn_Click);
            // 
            // txt_updateBtn
            // 
            this.txt_updateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_updateBtn.Location = new System.Drawing.Point(117, 3);
            this.txt_updateBtn.Name = "txt_updateBtn";
            this.txt_updateBtn.Size = new System.Drawing.Size(108, 38);
            this.txt_updateBtn.TabIndex = 1;
            this.txt_updateBtn.Text = "Sửa";
            this.txt_updateBtn.UseVisualStyleBackColor = true;
            this.txt_updateBtn.Click += new System.EventHandler(this.txt_updateBtn_Click);
            // 
            // txt_addBtn
            // 
            this.txt_addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_addBtn.Location = new System.Drawing.Point(3, 3);
            this.txt_addBtn.Name = "txt_addBtn";
            this.txt_addBtn.Size = new System.Drawing.Size(108, 38);
            this.txt_addBtn.TabIndex = 0;
            this.txt_addBtn.Text = "Thêm";
            this.txt_addBtn.UseVisualStyleBackColor = true;
            this.txt_addBtn.Click += new System.EventHandler(this.txt_addBtn_Click);
            // 
            // txt_gioiTinhNuRadio
            // 
            this.txt_gioiTinhNuRadio.AutoSize = true;
            this.txt_gioiTinhNuRadio.Location = new System.Drawing.Point(160, 19);
            this.txt_gioiTinhNuRadio.Name = "txt_gioiTinhNuRadio";
            this.txt_gioiTinhNuRadio.Size = new System.Drawing.Size(41, 19);
            this.txt_gioiTinhNuRadio.TabIndex = 5;
            this.txt_gioiTinhNuRadio.Text = "Nữ";
            this.txt_gioiTinhNuRadio.UseVisualStyleBackColor = true;
            this.txt_gioiTinhNuRadio.CheckedChanged += new System.EventHandler(this.txt_gioiTinhRadio_CheckedChanged);
            // 
            // txt_gioiTinhNamRadio
            // 
            this.txt_gioiTinhNamRadio.AutoSize = true;
            this.txt_gioiTinhNamRadio.Location = new System.Drawing.Point(72, 19);
            this.txt_gioiTinhNamRadio.Name = "txt_gioiTinhNamRadio";
            this.txt_gioiTinhNamRadio.Size = new System.Drawing.Size(51, 19);
            this.txt_gioiTinhNamRadio.TabIndex = 4;
            this.txt_gioiTinhNamRadio.Text = "Nam";
            this.txt_gioiTinhNamRadio.UseVisualStyleBackColor = true;
            this.txt_gioiTinhNamRadio.CheckedChanged += new System.EventHandler(this.txt_gioiTinhRadio_CheckedChanged);
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.AutoSize = true;
            this.txt_gioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_gioiTinh.Location = new System.Drawing.Point(3, 150);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(148, 50);
            this.txt_gioiTinh.TabIndex = 3;
            this.txt_gioiTinh.Text = "Giới tính";
            this.txt_gioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ngaySinhBox
            // 
            this.txt_ngaySinhBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ngaySinhBox.Location = new System.Drawing.Point(157, 203);
            this.txt_ngaySinhBox.Name = "txt_ngaySinhBox";
            this.txt_ngaySinhBox.Size = new System.Drawing.Size(456, 23);
            this.txt_ngaySinhBox.TabIndex = 2;
            // 
            // txt_diaChiBox
            // 
            this.txt_diaChiBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_diaChiBox.Location = new System.Drawing.Point(157, 263);
            this.txt_diaChiBox.Name = "txt_diaChiBox";
            this.txt_diaChiBox.Size = new System.Drawing.Size(456, 23);
            this.txt_diaChiBox.TabIndex = 1;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.AutoSize = true;
            this.txt_diaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_diaChi.Location = new System.Drawing.Point(3, 260);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(148, 30);
            this.txt_diaChi.TabIndex = 0;
            this.txt_diaChi.Text = "Địa chỉ";
            this.txt_diaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_hoVaTenBox
            // 
            this.txt_hoVaTenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_hoVaTenBox.Location = new System.Drawing.Point(157, 123);
            this.txt_hoVaTenBox.Name = "txt_hoVaTenBox";
            this.txt_hoVaTenBox.Size = new System.Drawing.Size(456, 23);
            this.txt_hoVaTenBox.TabIndex = 1;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.AutoSize = true;
            this.txt_ngaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ngaySinh.Location = new System.Drawing.Point(3, 200);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(148, 30);
            this.txt_ngaySinh.TabIndex = 0;
            this.txt_ngaySinh.Text = "Ngày sinh";
            this.txt_ngaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_noiSinhBox
            // 
            this.txt_noiSinhBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_noiSinhBox.Location = new System.Drawing.Point(157, 233);
            this.txt_noiSinhBox.Name = "txt_noiSinhBox";
            this.txt_noiSinhBox.Size = new System.Drawing.Size(456, 23);
            this.txt_noiSinhBox.TabIndex = 1;
            // 
            // txt_maNganhBox
            // 
            this.txt_maNganhBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maNganhBox.Location = new System.Drawing.Point(157, 93);
            this.txt_maNganhBox.Name = "txt_maNganhBox";
            this.txt_maNganhBox.Size = new System.Drawing.Size(456, 23);
            this.txt_maNganhBox.TabIndex = 1;
            // 
            // txt_maSVBox
            // 
            this.txt_maSVBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maSVBox.Location = new System.Drawing.Point(157, 63);
            this.txt_maSVBox.Name = "txt_maSVBox";
            this.txt_maSVBox.Size = new System.Drawing.Size(456, 23);
            this.txt_maSVBox.TabIndex = 1;
            // 
            // txt_noiSinh
            // 
            this.txt_noiSinh.AutoSize = true;
            this.txt_noiSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_noiSinh.Location = new System.Drawing.Point(3, 230);
            this.txt_noiSinh.Name = "txt_noiSinh";
            this.txt_noiSinh.Size = new System.Drawing.Size(148, 30);
            this.txt_noiSinh.TabIndex = 0;
            this.txt_noiSinh.Text = "Nơi sinh";
            this.txt_noiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_maNganh
            // 
            this.txt_maNganh.AutoSize = true;
            this.txt_maNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maNganh.Location = new System.Drawing.Point(3, 90);
            this.txt_maNganh.Name = "txt_maNganh";
            this.txt_maNganh.Size = new System.Drawing.Size(148, 30);
            this.txt_maNganh.TabIndex = 0;
            this.txt_maNganh.Text = "Mã Ngành";
            this.txt_maNganh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_hoVaTen
            // 
            this.txt_hoVaTen.AutoSize = true;
            this.txt_hoVaTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_hoVaTen.Location = new System.Drawing.Point(3, 120);
            this.txt_hoVaTen.Name = "txt_hoVaTen";
            this.txt_hoVaTen.Size = new System.Drawing.Size(148, 30);
            this.txt_hoVaTen.TabIndex = 0;
            this.txt_hoVaTen.Text = "Họ và Tên";
            this.txt_hoVaTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_maSV
            // 
            this.txt_maSV.AutoSize = true;
            this.txt_maSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maSV.Location = new System.Drawing.Point(3, 60);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(148, 30);
            this.txt_maSV.TabIndex = 0;
            this.txt_maSV.Text = "Mã SV";
            this.txt_maSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txt_diaChiBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dataDSSinhVien, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_ngaySinhBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_diaChi, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_maSV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_noiSinhBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_maSVBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_noiSinh, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_gioiTinh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_ngaySinh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_maNganhBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_maNganh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_hoVaTen, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_hoVaTenBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_gioiTinhNuRadio);
            this.groupBox1.Controls.Add(this.txt_gioiTinhNamRadio);
            this.groupBox1.Location = new System.Drawing.Point(157, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.txt_addBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_exitBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_updateBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_deleteBtn, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(157, 293);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(456, 44);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý thông tin sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QLTTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QLTTSV";
            this.Text = "Quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.FormQLTTSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSinhVien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataDSSinhVien;
        private Button txt_deleteBtn;
        private Button txt_updateBtn;
        private Button txt_addBtn;
        private Button txt_exitBtn;
        private RadioButton txt_gioiTinhNuRadio;
        private RadioButton txt_gioiTinhNamRadio;
        private Label txt_gioiTinh;
        private DateTimePicker txt_ngaySinhBox;
        private TextBox txt_diaChiBox;
        private Label txt_diaChi;
        private TextBox txt_hoVaTenBox;
        private Label txt_ngaySinh;
        private TextBox txt_noiSinhBox;
        private TextBox txt_maNganhBox;
        private TextBox txt_maSVBox;
        private Label txt_noiSinh;
        private Label txt_maNganh;
        private Label txt_hoVaTen;
        private Label txt_maSV;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
    }
}