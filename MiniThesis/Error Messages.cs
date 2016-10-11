using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniThesis
{
    class Errors
    {
        public void LoginError()
        {
            MessageBox.Show("Login Failed!\nInvalid Credentials!");
        }

        public void RdoBlankError()
        {
            MessageBox.Show("Please select type of login!");
        }
    }
}
