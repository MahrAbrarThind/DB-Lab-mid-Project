using DBMidProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject.Form_Panels
{
    public partial class deleteStudentsPanel : UserControl
    {
        public deleteStudentsPanel()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (rNumberTxtBox.Text == null)
            {
                MessageBox.Show("Enter Registration Number");
            }
            else
            {
                string rNumber = rNumberTxtBox.Text;
                if (StudentDL.chek_R_Number(rNumber))
                {
                    StudentDL.delete_Into_List(rNumber);
                    Configuration.DeleteStudentFromDb(rNumber);
                }
                else
                {
                    MessageBox.Show("Registration Number Deos Not Exist");
                }
            }
        }
    }
}
