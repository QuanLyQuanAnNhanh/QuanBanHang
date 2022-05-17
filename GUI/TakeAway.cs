using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class TakeAway : Form
    {
        MonAnBLL monAnBLL = new MonAnBLL();

        public TakeAway()
        {
            InitializeComponent();
        }

        private void TakeAway_Load(object sender, EventArgs e)
        {
            loadDSMonAnLenDataGridView();
        }

        public void loadDSMonAnLenDataGridView()
        {
           dataGridView_DSMonAn.DataSource = monAnBLL.LayMonAnBLL();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
