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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMenuPanel.Controls.Clear();
            mainMenuPanel.Controls.Add(new mainUserControlMenuPanel(mainMenuPanel,mainPanel));
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new userControlHomePanel());
        }
        private void mainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
