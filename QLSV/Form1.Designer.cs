namespace QLSV
{
    partial class Form1
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
            this.txt_sortComboBox = new System.Windows.Forms.ComboBox();
            this.txt_sortLabel = new System.Windows.Forms.Label();
            this.txt_searchBox = new System.Windows.Forms.TextBox();
            this.txt_searchBtn = new System.Windows.Forms.Button();
            this.txt_functions = new System.Windows.Forms.GroupBox();
            this.txt_exitBtn = new System.Windows.Forms.Button();
            this.txt_deleteBtn = new System.Windows.Forms.Button();
            this.txt_updateBtn = new System.Windows.Forms.Button();
            this.txt_addBtn = new System.Windows.Forms.Button();
            this.txt_ttsv = new System.Windows.Forms.GroupBox();
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
            this.txt_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSinhVien)).BeginInit();
            this.txt_functions.SuspendLayout();
            this.txt_ttsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDSSinhVien
            // 
            this.dataDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSSinhVien.Location = new System.Drawing.Point(12, 383);
            this.dataDSSinhVien.Name = "dataDSSinhVien";
            this.dataDSSinhVien.RowTemplate.Height = 25;
            this.dataDSSinhVien.Size = new System.Drawing.Size(753, 140);
            this.dataDSSinhVien.TabIndex = 2;
            // 
            // txt_sortComboBox
            // 
            this.txt_sortComboBox.FormattingEnabled = true;
            this.txt_sortComboBox.Location = new System.Drawing.Point(190, 355);
            this.txt_sortComboBox.Name = "txt_sortComboBox";
            this.txt_sortComboBox.Size = new System.Drawing.Size(121, 23);
            this.txt_sortComboBox.TabIndex = 4;
            // 
            // txt_sortLabel
            // 
            this.txt_sortLabel.AutoSize = true;
            this.txt_sortLabel.Location = new System.Drawing.Point(136, 358);
            this.txt_sortLabel.Name = "txt_sortLabel";
            this.txt_sortLabel.Size = new System.Drawing.Size(48, 15);
            this.txt_sortLabel.TabIndex = 5;
            this.txt_sortLabel.Text = "Sắp xếp";
            // 
            // txt_searchBox
            // 
            this.txt_searchBox.Location = new System.Drawing.Point(477, 354);
            this.txt_searchBox.Name = "txt_searchBox";
            this.txt_searchBox.Size = new System.Drawing.Size(145, 23);
            this.txt_searchBox.TabIndex = 6;
            // 
            // txt_searchBtn
            // 
            this.txt_searchBtn.Location = new System.Drawing.Point(628, 354);
            this.txt_searchBtn.Name = "txt_searchBtn";
            this.txt_searchBtn.Size = new System.Drawing.Size(75, 23);
            this.txt_searchBtn.TabIndex = 7;
            this.txt_searchBtn.Text = "Tìm kiếm";
            this.txt_searchBtn.UseVisualStyleBackColor = true;
            // 
            // txt_functions
            // 
            this.txt_functions.Controls.Add(this.txt_exitBtn);
            this.txt_functions.Controls.Add(this.txt_deleteBtn);
            this.txt_functions.Controls.Add(this.txt_updateBtn);
            this.txt_functions.Controls.Add(this.txt_addBtn);
            this.txt_functions.Location = new System.Drawing.Point(539, 93);
            this.txt_functions.Name = "txt_functions";
            this.txt_functions.Size = new System.Drawing.Size(226, 222);
            this.txt_functions.TabIndex = 8;
            this.txt_functions.TabStop = false;
            this.txt_functions.Text = "Chức năng";
            // 
            // txt_exitBtn
            // 
            this.txt_exitBtn.Location = new System.Drawing.Point(6, 164);
            this.txt_exitBtn.Name = "txt_exitBtn";
            this.txt_exitBtn.Size = new System.Drawing.Size(214, 34);
            this.txt_exitBtn.TabIndex = 3;
            this.txt_exitBtn.Text = "Thoát";
            this.txt_exitBtn.UseVisualStyleBackColor = true;
            // 
            // txt_deleteBtn
            // 
            this.txt_deleteBtn.Location = new System.Drawing.Point(6, 124);
            this.txt_deleteBtn.Name = "txt_deleteBtn";
            this.txt_deleteBtn.Size = new System.Drawing.Size(214, 34);
            this.txt_deleteBtn.TabIndex = 2;
            this.txt_deleteBtn.Text = "Xóa";
            this.txt_deleteBtn.UseVisualStyleBackColor = true;
            // 
            // txt_updateBtn
            // 
            this.txt_updateBtn.Location = new System.Drawing.Point(6, 84);
            this.txt_updateBtn.Name = "txt_updateBtn";
            this.txt_updateBtn.Size = new System.Drawing.Size(214, 34);
            this.txt_updateBtn.TabIndex = 1;
            this.txt_updateBtn.Text = "Sửa";
            this.txt_updateBtn.UseVisualStyleBackColor = true;
            // 
            // txt_addBtn
            // 
            this.txt_addBtn.Location = new System.Drawing.Point(6, 44);
            this.txt_addBtn.Name = "txt_addBtn";
            this.txt_addBtn.Size = new System.Drawing.Size(214, 34);
            this.txt_addBtn.TabIndex = 0;
            this.txt_addBtn.Text = "Thêm";
            this.txt_addBtn.UseVisualStyleBackColor = true;
            this.txt_addBtn.Click += new System.EventHandler(this.txt_addBtn_Click);
            // 
            // txt_ttsv
            // 
            this.txt_ttsv.Controls.Add(this.txt_gioiTinhNuRadio);
            this.txt_ttsv.Controls.Add(this.txt_gioiTinhNamRadio);
            this.txt_ttsv.Controls.Add(this.txt_gioiTinh);
            this.txt_ttsv.Controls.Add(this.txt_ngaySinhBox);
            this.txt_ttsv.Controls.Add(this.txt_diaChiBox);
            this.txt_ttsv.Controls.Add(this.txt_diaChi);
            this.txt_ttsv.Controls.Add(this.txt_hoVaTenBox);
            this.txt_ttsv.Controls.Add(this.txt_ngaySinh);
            this.txt_ttsv.Controls.Add(this.txt_noiSinhBox);
            this.txt_ttsv.Controls.Add(this.txt_maNganhBox);
            this.txt_ttsv.Controls.Add(this.txt_maSVBox);
            this.txt_ttsv.Controls.Add(this.txt_noiSinh);
            this.txt_ttsv.Controls.Add(this.txt_maNganh);
            this.txt_ttsv.Controls.Add(this.txt_hoVaTen);
            this.txt_ttsv.Controls.Add(this.txt_maSV);
            this.txt_ttsv.Location = new System.Drawing.Point(12, 93);
            this.txt_ttsv.Name = "txt_ttsv";
            this.txt_ttsv.Size = new System.Drawing.Size(502, 222);
            this.txt_ttsv.TabIndex = 9;
            this.txt_ttsv.TabStop = false;
            this.txt_ttsv.Text = "Thông tin sinh viên";
            // 
            // txt_gioiTinhNuRadio
            // 
            this.txt_gioiTinhNuRadio.AutoSize = true;
            this.txt_gioiTinhNuRadio.Location = new System.Drawing.Point(418, 85);
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
            this.txt_gioiTinhNamRadio.Checked = true;
            this.txt_gioiTinhNamRadio.Location = new System.Drawing.Point(342, 85);
            this.txt_gioiTinhNamRadio.Name = "txt_gioiTinhNamRadio";
            this.txt_gioiTinhNamRadio.Size = new System.Drawing.Size(51, 19);
            this.txt_gioiTinhNamRadio.TabIndex = 4;
            this.txt_gioiTinhNamRadio.TabStop = true;
            this.txt_gioiTinhNamRadio.Text = "Nam";
            this.txt_gioiTinhNamRadio.UseVisualStyleBackColor = true;
            this.txt_gioiTinhNamRadio.CheckedChanged += new System.EventHandler(this.txt_gioiTinhRadio_CheckedChanged);
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.AutoSize = true;
            this.txt_gioiTinh.Location = new System.Drawing.Point(261, 87);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(52, 15);
            this.txt_gioiTinh.TabIndex = 3;
            this.txt_gioiTinh.Text = "Giới tính";
            // 
            // txt_ngaySinhBox
            // 
            this.txt_ngaySinhBox.Location = new System.Drawing.Point(78, 132);
            this.txt_ngaySinhBox.Name = "txt_ngaySinhBox";
            this.txt_ngaySinhBox.Size = new System.Drawing.Size(165, 23);
            this.txt_ngaySinhBox.TabIndex = 2;
            // 
            // txt_diaChiBox
            // 
            this.txt_diaChiBox.Location = new System.Drawing.Point(78, 184);
            this.txt_diaChiBox.Name = "txt_diaChiBox";
            this.txt_diaChiBox.Size = new System.Drawing.Size(404, 23);
            this.txt_diaChiBox.TabIndex = 1;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.AutoSize = true;
            this.txt_diaChi.Location = new System.Drawing.Point(13, 187);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(43, 15);
            this.txt_diaChi.TabIndex = 0;
            this.txt_diaChi.Text = "Địa chỉ";
            // 
            // txt_hoVaTenBox
            // 
            this.txt_hoVaTenBox.Location = new System.Drawing.Point(78, 84);
            this.txt_hoVaTenBox.Name = "txt_hoVaTenBox";
            this.txt_hoVaTenBox.Size = new System.Drawing.Size(165, 23);
            this.txt_hoVaTenBox.TabIndex = 1;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.AutoSize = true;
            this.txt_ngaySinh.Location = new System.Drawing.Point(13, 138);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(60, 15);
            this.txt_ngaySinh.TabIndex = 0;
            this.txt_ngaySinh.Text = "Ngày sinh";
            // 
            // txt_noiSinhBox
            // 
            this.txt_noiSinhBox.Location = new System.Drawing.Point(330, 132);
            this.txt_noiSinhBox.Name = "txt_noiSinhBox";
            this.txt_noiSinhBox.Size = new System.Drawing.Size(152, 23);
            this.txt_noiSinhBox.TabIndex = 1;
            // 
            // txt_maNganhBox
            // 
            this.txt_maNganhBox.Location = new System.Drawing.Point(330, 31);
            this.txt_maNganhBox.Name = "txt_maNganhBox";
            this.txt_maNganhBox.Size = new System.Drawing.Size(152, 23);
            this.txt_maNganhBox.TabIndex = 1;
            // 
            // txt_maSVBox
            // 
            this.txt_maSVBox.Location = new System.Drawing.Point(78, 31);
            this.txt_maSVBox.Name = "txt_maSVBox";
            this.txt_maSVBox.Size = new System.Drawing.Size(165, 23);
            this.txt_maSVBox.TabIndex = 1;
            // 
            // txt_noiSinh
            // 
            this.txt_noiSinh.AutoSize = true;
            this.txt_noiSinh.Location = new System.Drawing.Point(263, 135);
            this.txt_noiSinh.Name = "txt_noiSinh";
            this.txt_noiSinh.Size = new System.Drawing.Size(51, 15);
            this.txt_noiSinh.TabIndex = 0;
            this.txt_noiSinh.Text = "Nơi sinh";
            // 
            // txt_maNganh
            // 
            this.txt_maNganh.AutoSize = true;
            this.txt_maNganh.Location = new System.Drawing.Point(261, 34);
            this.txt_maNganh.Name = "txt_maNganh";
            this.txt_maNganh.Size = new System.Drawing.Size(63, 15);
            this.txt_maNganh.TabIndex = 0;
            this.txt_maNganh.Text = "Mã Ngành";
            // 
            // txt_hoVaTen
            // 
            this.txt_hoVaTen.AutoSize = true;
            this.txt_hoVaTen.Location = new System.Drawing.Point(13, 87);
            this.txt_hoVaTen.Name = "txt_hoVaTen";
            this.txt_hoVaTen.Size = new System.Drawing.Size(59, 15);
            this.txt_hoVaTen.TabIndex = 0;
            this.txt_hoVaTen.Text = "Họ và Tên";
            // 
            // txt_maSV
            // 
            this.txt_maSV.AutoSize = true;
            this.txt_maSV.Location = new System.Drawing.Point(13, 34);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(40, 15);
            this.txt_maSV.TabIndex = 0;
            this.txt_maSV.Text = "Mã SV";
            // 
            // txt_header
            // 
            this.txt_header.AutoSize = true;
            this.txt_header.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_header.Location = new System.Drawing.Point(275, 25);
            this.txt_header.Name = "txt_header";
            this.txt_header.Size = new System.Drawing.Size(219, 37);
            this.txt_header.TabIndex = 10;
            this.txt_header.Text = "Quản lý sinh viên";
            this.txt_header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 532);
            this.Controls.Add(this.txt_header);
            this.Controls.Add(this.txt_ttsv);
            this.Controls.Add(this.txt_functions);
            this.Controls.Add(this.txt_searchBtn);
            this.Controls.Add(this.txt_searchBox);
            this.Controls.Add(this.txt_sortLabel);
            this.Controls.Add(this.txt_sortComboBox);
            this.Controls.Add(this.dataDSSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSinhVien)).EndInit();
            this.txt_functions.ResumeLayout(false);
            this.txt_ttsv.ResumeLayout(false);
            this.txt_ttsv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataDSSinhVien;
        private ComboBox txt_sortComboBox;
        private Label txt_sortLabel;
        private TextBox txt_searchBox;
        private Button txt_searchBtn;
        private GroupBox txt_functions;
        private GroupBox txt_ttsv;
        private Label txt_header;
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
    }
}