namespace GUI
{
    partial class NhapNguyenLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheBen = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_MonAn = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.rdbMonAnCanNhap = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuongNguyenLieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaNguyenLieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbNhapNguyenLieu = new System.Windows.Forms.RadioButton();
            this.btnNhapNguyenLieu = new System.Windows.Forms.Button();
            this.btnThemMoiNguyenLieu = new System.Windows.Forms.Button();
            this.cmbDVTNguyenLieu = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbTenNguyenLieu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonAn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheBen);
            this.panel1.Controls.Add(this.rdbMonAnCanNhap);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenMonAn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView_MonAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 458);
            this.panel1.TabIndex = 0;
            // 
            // btnCheBen
            // 
            this.btnCheBen.Location = new System.Drawing.Point(445, 381);
            this.btnCheBen.Name = "btnCheBen";
            this.btnCheBen.Size = new System.Drawing.Size(178, 41);
            this.btnCheBen.TabIndex = 7;
            this.btnCheBen.Text = "Chế Biến";
            this.btnCheBen.UseVisualStyleBackColor = true;
            this.btnCheBen.Click += new System.EventHandler(this.btnCheBen_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(138, 387);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(261, 30);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Lượng";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Enabled = false;
            this.txtTenMonAn.Location = new System.Drawing.Point(138, 324);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(261, 30);
            this.txtTenMonAn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Món Ăn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(643, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 210);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView_MonAn
            // 
            this.dataGridView_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_MonAn.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MonAn.Name = "dataGridView_MonAn";
            this.dataGridView_MonAn.RowTemplate.Height = 24;
            this.dataGridView_MonAn.Size = new System.Drawing.Size(651, 245);
            this.dataGridView_MonAn.TabIndex = 0;
            this.dataGridView_MonAn.SelectionChanged += new System.EventHandler(this.dataGridView_MonAn_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTenNguyenLieu);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.cmbDVTNguyenLieu);
            this.panel2.Controls.Add(this.btnThemMoiNguyenLieu);
            this.panel2.Controls.Add(this.btnNhapNguyenLieu);
            this.panel2.Controls.Add(this.rdbNhapNguyenLieu);
            this.panel2.Controls.Add(this.txtGiaNguyenLieu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoLuongNguyenLieu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView_NguyenLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(646, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 458);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_NguyenLieu
            // 
            this.dataGridView_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NguyenLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_NguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_NguyenLieu.Name = "dataGridView_NguyenLieu";
            this.dataGridView_NguyenLieu.RowTemplate.Height = 24;
            this.dataGridView_NguyenLieu.Size = new System.Drawing.Size(689, 245);
            this.dataGridView_NguyenLieu.TabIndex = 0;
            this.dataGridView_NguyenLieu.SelectionChanged += new System.EventHandler(this.dataGridView_NguyenLieu_SelectionChanged);
            // 
            // rdbMonAnCanNhap
            // 
            this.rdbMonAnCanNhap.AutoSize = true;
            this.rdbMonAnCanNhap.Location = new System.Drawing.Point(445, 323);
            this.rdbMonAnCanNhap.Name = "rdbMonAnCanNhap";
            this.rdbMonAnCanNhap.Size = new System.Drawing.Size(178, 26);
            this.rdbMonAnCanNhap.TabIndex = 6;
            this.rdbMonAnCanNhap.TabStop = true;
            this.rdbMonAnCanNhap.Text = "Món Ăn Cần Nhập";
            this.rdbMonAnCanNhap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Nguyên Liệu";
            // 
            // txtSoLuongNguyenLieu
            // 
            this.txtSoLuongNguyenLieu.Location = new System.Drawing.Point(163, 315);
            this.txtSoLuongNguyenLieu.Name = "txtSoLuongNguyenLieu";
            this.txtSoLuongNguyenLieu.Size = new System.Drawing.Size(261, 30);
            this.txtSoLuongNguyenLieu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // txtGiaNguyenLieu
            // 
            this.txtGiaNguyenLieu.Location = new System.Drawing.Point(163, 416);
            this.txtGiaNguyenLieu.Name = "txtGiaNguyenLieu";
            this.txtGiaNguyenLieu.Size = new System.Drawing.Size(261, 30);
            this.txtGiaNguyenLieu.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giá Nguyên Liệu";
            // 
            // rdbNhapNguyenLieu
            // 
            this.rdbNhapNguyenLieu.AutoSize = true;
            this.rdbNhapNguyenLieu.Location = new System.Drawing.Point(464, 267);
            this.rdbNhapNguyenLieu.Name = "rdbNhapNguyenLieu";
            this.rdbNhapNguyenLieu.Size = new System.Drawing.Size(213, 26);
            this.rdbNhapNguyenLieu.TabIndex = 16;
            this.rdbNhapNguyenLieu.TabStop = true;
            this.rdbNhapNguyenLieu.Text = "Nguyên Liệu Cần Nhập";
            this.rdbNhapNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btnNhapNguyenLieu
            // 
            this.btnNhapNguyenLieu.Location = new System.Drawing.Point(445, 304);
            this.btnNhapNguyenLieu.Name = "btnNhapNguyenLieu";
            this.btnNhapNguyenLieu.Size = new System.Drawing.Size(232, 41);
            this.btnNhapNguyenLieu.TabIndex = 8;
            this.btnNhapNguyenLieu.Text = "Nhập Nguyên Liệu";
            this.btnNhapNguyenLieu.UseVisualStyleBackColor = true;
            this.btnNhapNguyenLieu.Click += new System.EventHandler(this.btnNhapNguyenLieu_Click);
            // 
            // btnThemMoiNguyenLieu
            // 
            this.btnThemMoiNguyenLieu.Location = new System.Drawing.Point(445, 405);
            this.btnThemMoiNguyenLieu.Name = "btnThemMoiNguyenLieu";
            this.btnThemMoiNguyenLieu.Size = new System.Drawing.Size(232, 41);
            this.btnThemMoiNguyenLieu.TabIndex = 17;
            this.btnThemMoiNguyenLieu.Text = "Thêm Nguyên Liệu Mới";
            this.btnThemMoiNguyenLieu.UseVisualStyleBackColor = true;
            this.btnThemMoiNguyenLieu.Click += new System.EventHandler(this.btnThemMoiNguyenLieu_Click);
            // 
            // cmbDVTNguyenLieu
            // 
            this.cmbDVTNguyenLieu.FormattingEnabled = true;
            this.cmbDVTNguyenLieu.Location = new System.Drawing.Point(163, 371);
            this.cmbDVTNguyenLieu.Name = "cmbDVTNguyenLieu";
            this.cmbDVTNguyenLieu.Size = new System.Drawing.Size(261, 30);
            this.cmbDVTNguyenLieu.TabIndex = 18;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(445, 352);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(232, 41);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbTenNguyenLieu
            // 
            this.cmbTenNguyenLieu.FormattingEnabled = true;
            this.cmbTenNguyenLieu.Location = new System.Drawing.Point(163, 263);
            this.cmbTenNguyenLieu.Name = "cmbTenNguyenLieu";
            this.cmbTenNguyenLieu.Size = new System.Drawing.Size(261, 30);
            this.cmbTenNguyenLieu.TabIndex = 20;
            // 
            // NhapNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NhapNguyenLieu";
            this.Text = "NhapNguyenLieu";
            this.Load += new System.EventHandler(this.NhapNguyenLieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_MonAn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_NguyenLieu;
        private System.Windows.Forms.RadioButton rdbMonAnCanNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheBen;
        private System.Windows.Forms.Button btnThemMoiNguyenLieu;
        private System.Windows.Forms.Button btnNhapNguyenLieu;
        private System.Windows.Forms.RadioButton rdbNhapNguyenLieu;
        private System.Windows.Forms.TextBox txtGiaNguyenLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongNguyenLieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDVTNguyenLieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cmbTenNguyenLieu;
    }
}