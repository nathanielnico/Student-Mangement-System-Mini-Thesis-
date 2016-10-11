using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniThesis
{
    class Success_Message
    {
        public void FacultyLoginSucces()
        {
            MessageBox.Show("Login Success!\nWelcome Faculty!");
        }

        public void AdminLoginSuccess()
        {
            MessageBox.Show("Login Succes!\nWelcom Admin!");
        }

        public void StudentLoginSuccess()
        {
            MessageBox.Show("Login Success!\nWelcome Student!");
        }
    }
}
