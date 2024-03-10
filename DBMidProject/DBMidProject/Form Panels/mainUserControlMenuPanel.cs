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
    public partial class mainUserControlMenuPanel : UserControl
    {
        Panel panel1;
        Panel panel2;

        public mainUserControlMenuPanel(Panel panel1, Panel panel2)
        {

            InitializeComponent();
            this.panel1 = panel1;
            this.panel2 = panel2;
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new viewStudentsPanel());
            panel1.Controls.Clear();
            panel1.Controls.Add(new StudentMenuPanel(panel1, panel2));
        }

        private void rubricsBtn_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new rubricsPanel());
        }

        private void assessmentsBtn_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new assessmentsPanel());
        }

        private void rlevelsBtn_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new rubricsLevelPanel());
        }

        private void closBtn_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new CLOsPanel());
        }
        private void mainUserControlMenuPanel_Load(object sender, EventArgs e)
        {

        }


    }
}
