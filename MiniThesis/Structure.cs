using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniThesis
{
    abstract class SchoolPeople
    {
        public string Fname {get; set;}
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tnumber { get; set; }
        public string Mnumber { get; set; }
        public string Section { get; set; }

        public virtual void CheckSectionInfo()
        {
            //To be edited
        }
        //You think more functions IDIOT
        public virtual void CheckTeacherInfo()
        {

        }
        public virtual void EnrollStudent()
        {

        }
    }

    class Student: SchoolPeople
    {
        public override void CheckTeacherInfo()
        {
            base.CheckTeacherInfo();
        }

        public virtual void EditStudentInfo()
        {

        }


    }

    class Teacher : SchoolPeople
    {

    }
    class Faculty : SchoolPeople
    {

    }
}
