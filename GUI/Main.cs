using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //CollapseMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn3Lines_Click(object sender, EventArgs e)
        {
            //CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMain.Width > 200)
            {
                panelMain.Width = 100;
                lblMain.Visible = false;
                btn3Lines.Dock = DockStyle.Top;
                foreach(Button listButton in panelMain.Controls.OfType<Button>())
                {
                    listButton.Text = "";
                    listButton.ImageAlign = ContentAlignment.MiddleCenter;
                    listButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMain.Width = 230;
                lblMain.Visible = true;
                btn3Lines.Dock = DockStyle.None;
                foreach (Button listButton in panelMain.Controls.OfType<Button>())
                {
                    listButton.Text = "   " + listButton.Tag.ToString();
                    listButton.ImageAlign = ContentAlignment.MiddleCenter;
                    listButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
    }
}
