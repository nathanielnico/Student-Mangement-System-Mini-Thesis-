using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniThesis
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            this.Hide();
            log.Show();
        }

        private void viewClassInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionInfo viewSec = new SectionInfo();
            viewSec.MdiParent = this;
            viewSec.Show();
            
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent_Info studInfo = new frmStudent_Info();
            studInfo.MdiParent = this;
            studInfo.Show();
        }
    }
}
