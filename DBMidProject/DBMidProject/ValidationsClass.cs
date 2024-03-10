using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    internal class ValidationsClass
    {
        public static bool ValidateFields(string firstName,string lastName,string contact,string email,string rNumber,string status)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(rNumber) ||
                string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
