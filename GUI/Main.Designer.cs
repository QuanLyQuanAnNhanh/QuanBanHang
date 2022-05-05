namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btn3Lines = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.thumbnail1 = new GUI.Thumbnail();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMain.Controls.Add(this.panel6);
            this.panelMain.Controls.Add(this.panel5);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.btnTakeAway);
            this.panelMain.Controls.Add(this.btnThoat);
            this.panelMain.Controls.Add(this.btnNhanVien);
            this.panelMain.Controls.Add(this.btnThongKe);
            this.panelMain.Controls.Add(this.btnEatIn);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.btn3Lines);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(291, 640);
            this.panelMain.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(42, 575);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(185, 53);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Tag = "Exit";
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(42, 426);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(185, 53);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Tag = "Employee";
            this.btnNhanVien.Text = "   Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(42, 347);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(185, 53);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Tag = "Calculating";
            this.btnThongKe.Text = "    Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnEatIn
            // 
            this.btnEatIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEatIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatIn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatIn.Image = ((System.Drawing.Image)(resources.GetObject("btnEatIn.Image")));
            this.btnEatIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEatIn.Location = new System.Drawing.Point(42, 193);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(185, 53);
            this.btnEatIn.TabIndex = 3;
            this.btnEatIn.Tag = "EatIn";
            this.btnEatIn.Text = "      Eat-In";
            this.btnEatIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEatIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEatIn.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(42, 112);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(185, 53);
            this.btnHome.TabIndex = 2;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "      Món Ăn";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btn3Lines
            // 
            this.btn3Lines.BackColor = System.Drawing.Color.LightGray;
            this.btn3Lines.Image = ((System.Drawing.Image)(resources.GetObject("btn3Lines.Image")));
            this.btn3Lines.Location = new System.Drawing.Point(144, 27);
            this.btn3Lines.Name = "btn3Lines";
            this.btn3Lines.Size = new System.Drawing.Size(83, 51);
            this.btn3Lines.TabIndex = 1;
            this.btn3Lines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3Lines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn3Lines.UseVisualStyleBackColor = false;
            this.btn3Lines.Click += new System.EventHandler(this.btn3Lines_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMain.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMain.Location = new System.Drawing.Point(21, 38);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(102, 24);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Trang Chủ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.thumbnail1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 640);
            this.panel2.TabIndex = 1;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeAway.Image")));
            this.btnTakeAway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeAway.Location = new System.Drawing.Point(42, 269);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(185, 53);
            this.btnTakeAway.TabIndex = 12;
            this.btnTakeAway.Tag = "EatOut";
            this.btnTakeAway.Text = "  Take-Away";
            this.btnTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTakeAway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeAway.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(35, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 53);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(35, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 53);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(35, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 53);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(35, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 53);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(35, 426);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 53);
            this.panel6.TabIndex = 14;
            // 
            // thumbnail1
            // 
            this.thumbnail1.Location = new System.Drawing.Point(-12, 60);
            this.thumbnail1.Name = "thumbnail1";
            this.thumbnail1.Size = new System.Drawing.Size(877, 428);
            this.thumbnail1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMain);
            this.Name = "Main";
            this.Text = "Main";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btn3Lines;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Thumbnail thumbnail1;
    }
}