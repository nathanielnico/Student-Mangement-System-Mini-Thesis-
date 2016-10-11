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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Transfer Variable
            Username = txt_Username.Text;
            Password = txt_Password.Text;

            //Instantiates Stuff
            Success_Message sucs = new Success_Message();
            Errors err = new Errors();
            frmMain factly = new frmMain();
            frmStudentMain stud = new frmStudentMain();


            //Login Logic
            if (rdo_Admin.Checked)
            {
                if (Username == "admin" && Password == "admin")
                {
                    sucs.AdminLoginSuccess();
                    this.Hide();
                    factly.Show();
                }
                else
                {
                    err.LoginError();
                }
            }
            else if (rdo_Faculty.Checked)
            {
                if (Username == "faculty" && Password == "faculty")
                {
                    sucs.FacultyLoginSucces();
                    factly.Show();
                    this.Hide();
                }
                else
                {
                    err.LoginError();
                }
            }
            else if (rdo_Student.Checked)
            {
                if (Username == "student" && Password == "pass")
                {
                    sucs.StudentLoginSuccess();
                    this.Hide();
                    stud.Show();
                }
                else
                {
                    err.LoginError();
                }
            }
            else
            {
                err.RdoBlankError();
            }
        }
    }
}
