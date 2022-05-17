namespace GUI
{
    partial class MonAn
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cmbTenMonAn = new System.Windows.Forms.ComboBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_MonAn = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLưu = new System.Windows.Forms.Button();
            this.btnSuaGia = new System.Windows.Forms.Button();
            this.btnNhapMon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonAn)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtSLNhap);
            this.panel2.Controls.Add(this.cmbDVT);
            this.panel2.Controls.Add(this.cmbLoai);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.cmbTenMonAn);
            this.panel2.Controls.Add(this.txtMaMonAn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 212);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 30);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "VND";
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Enabled = false;
            this.txtSLNhap.Location = new System.Drawing.Point(250, 66);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(221, 30);
            this.txtSLNhap.TabIndex = 17;
            // 
            // cmbDVT
            // 
            this.cmbDVT.FormattingEnabled = true;
            this.cmbDVT.Location = new System.Drawing.Point(483, 145);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(221, 30);
            this.cmbDVT.TabIndex = 13;
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(486, 66);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(221, 30);
            this.cmbLoai.TabIndex = 12;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(247, 145);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(175, 30);
            this.txtGiaBan.TabIndex = 9;
            this.txtGiaBan.Enter += new System.EventHandler(this.txtGiaBan_Enter);
            // 
            // cmbTenMonAn
            // 
            this.cmbTenMonAn.FormattingEnabled = true;
            this.cmbTenMonAn.Location = new System.Drawing.Point(9, 145);
            this.cmbTenMonAn.Name = "cmbTenMonAn";
            this.cmbTenMonAn.Size = new System.Drawing.Size(221, 30);
            this.cmbTenMonAn.TabIndex = 7;
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Enabled = false;
            this.txtMaMonAn.Location = new System.Drawing.Point(12, 66);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(221, 30);
            this.txtMaMonAn.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng Hiện Có";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Món Ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Món Ăn";
            // 
            // dataGridView_MonAn
            // 
            this.dataGridView_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MonAn.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MonAn.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_MonAn.Name = "dataGridView_MonAn";
            this.dataGridView_MonAn.RowTemplate.Height = 24;
            this.dataGridView_MonAn.Size = new System.Drawing.Size(1135, 287);
            this.dataGridView_MonAn.TabIndex = 0;
            this.dataGridView_MonAn.SelectionChanged += new System.EventHandler(this.dataGridView_MonAn_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 536);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnThemMon);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnLưu);
            this.tabPage1.Controls.Add(this.btnSuaGia);
            this.tabPage1.Controls.Add(this.btnNhapMon);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1141, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món Ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(745, 426);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(168, 62);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.Text = "Thêm Món Ăn";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_MonAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 287);
            this.panel1.TabIndex = 0;
            // 
            // btnLưu
            // 
            this.btnLưu.Location = new System.Drawing.Point(981, 429);
            this.btnLưu.Name = "btnLưu";
            this.btnLưu.Size = new System.Drawing.Size(152, 62);
            this.btnLưu.TabIndex = 5;
            this.btnLưu.Text = "Lưu";
            this.btnLưu.UseVisualStyleBackColor = true;
            this.btnLưu.Click += new System.EventHandler(this.btnLưu_Click);
            // 
            // btnSuaGia
            // 
            this.btnSuaGia.Location = new System.Drawing.Point(981, 318);
            this.btnSuaGia.Name = "btnSuaGia";
            this.btnSuaGia.Size = new System.Drawing.Size(152, 62);
            this.btnSuaGia.TabIndex = 3;
            this.btnSuaGia.Text = "Sửa Giá Bán";
            this.btnSuaGia.UseVisualStyleBackColor = true;
            this.btnSuaGia.Click += new System.EventHandler(this.btnSuaGia_Click);
            // 
            // btnNhapMon
            // 
            this.btnNhapMon.Location = new System.Drawing.Point(745, 318);
            this.btnNhapMon.Name = "btnNhapMon";
            this.btnNhapMon.Size = new System.Drawing.Size(168, 62);
            this.btnNhapMon.TabIndex = 2;
            this.btnNhapMon.Text = "Nhập Nguyên Liệu";
            this.btnNhapMon.UseVisualStyleBackColor = true;
            this.btnNhapMon.Click += new System.EventHandler(this.btnNhapMon_Click);
            // 
            // MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 536);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonAn";
            this.Text = "MonAn";
            this.Load += new System.EventHandler(this.MonAn_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonAn)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDVT;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cmbTenMonAn;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.DataGridView dataGridView_MonAn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLưu;
        private System.Windows.Forms.Button btnSuaGia;
        private System.Windows.Forms.Button btnNhapMon;
        private System.Windows.Forms.TextBox textBox1;
    }
}