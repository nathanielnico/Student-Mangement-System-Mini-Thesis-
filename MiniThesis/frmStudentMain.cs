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
    public partial class frmStudentMain : Form
    {
        public frmStudentMain()
        {
            InitializeComponent();
        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent_Info stdinfo = new frmStudent_Info();
            stdinfo.MdiParent = this;
            stdinfo.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            this.Hide();
            logout.Show();
            
        }

        private void classAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Available_Classes availClass = new Available_Classes();
            availClass.MdiParent = this;
            availClass.Show();
        }

        private void classInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionInfo secInfo = new SectionInfo();
            secInfo.MdiParent = this;
            secInfo.Show();
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherInfo teachInfo = new frmTeacherInfo();
            teachInfo.MdiParent = this;
            teachInfo.Show();
        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentBalance checkBal = new frmStudentBalance();
            checkBal.MdiParent = this;
            checkBal.Show();
        }
    }
}
