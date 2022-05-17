using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class LogIn : Form
    {
        Settings st = new Settings();
        TaiKhoanBLL tk_bll = new TaiKhoanBLL();

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Username Không Được Trống");
                this.txtUser.Focus();
                return;
            }

            if(string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Password Không Được Trống");
                this.txtPass.Focus();
                return;
            }

            int kq = tk_bll.Check_TK_BLL(txtUser.Text, txtPass.Text);
            
            if(kq==1)
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                Main fm = new Main();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Sai!");
            }
        }
    }
}
