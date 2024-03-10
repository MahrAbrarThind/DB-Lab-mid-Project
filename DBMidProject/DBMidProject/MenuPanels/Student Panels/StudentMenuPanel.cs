using DBMidProject.Form_Panels;
using DBMidProject.MenuPanels.Attendence_Panels;
using DBMidProject.MenuPanels.Student_Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class StudentMenuPanel : UserControl
    {
        Panel panel1;
        Panel panel2;
        public StudentMenuPanel(Panel panel1, Panel panel2)
        {
            InitializeComponent();
            this.panel1 = panel1;
            this.panel2 = panel2;
        }

        private void addStudentMenuBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AddstudentsPanel());
        }

        private void updateStudentMenuBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new updateStudentsPanel());
        }

        private void deleteStudentMenuBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new deleteStudentsPanel());
        }

        private void viewStudentMenuBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new viewStudentsPanel());
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new mainUserControlMenuPanel(panel1, panel2));
            panel2.Controls.Clear();
            panel2.Controls.Add(new userControlHomePanel());
        }

        private void markAttendenceBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new studentAttendencePanel());
        }
    }
}
