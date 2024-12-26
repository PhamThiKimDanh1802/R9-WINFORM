using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MYAPP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDoUong DoUong = new FrmDoUong();
            DoUong.MdiParent = this;
            DoUong.Show();
        }
    }
}
