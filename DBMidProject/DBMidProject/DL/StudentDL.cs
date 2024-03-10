using DBMidProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject.DL
{
    internal class StudentDL
    {
        public static List<StudentBL> studentsList =  new List<StudentBL>();

        public static void add_Student_Into_List(StudentBL student)
        {
            studentsList.Add(student);
        }
        public static void update_Into_List(StudentBL student)
        {
            foreach(var a in studentsList)
            {
                if(a.RegistrationNumber == student.RegistrationNumber) 
                {
                    a.FirstName = student.FirstName; a.LastName=student.LastName;
                    a.Contact=student.Contact;a.Email = student.Email;
                    a.Status = student.Status;
                }
            }
        }
        public static void delete_Into_List(string rNumber)
        {
            foreach (var a in studentsList)
            {
                if (a.RegistrationNumber == rNumber)
                {
                    a.Status = 6;
                }
            }
        }
        public static bool chek_R_Number(string rNumber)
        {
            foreach(var a in studentsList)
            {
                if (a.RegistrationNumber == rNumber)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
