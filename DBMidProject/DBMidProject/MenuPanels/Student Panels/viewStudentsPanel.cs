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

namespace DBMidProject.MenuPanels.Student_Panels
{
    public partial class viewStudentsPanel : UserControl
    {
        DataTable table = new DataTable();

        public viewStudentsPanel()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void viewStudentsPanel_Load(object sender, EventArgs e)
        {
            Configuration.LoadDataFromDb();
            InitializeDataTable();
            addDataToGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void InitializeDataTable()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Contact", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Registration No", typeof(string));
            table.Columns.Add("Status", typeof(string));

        }
        public void addDataToGrid()
        {
            dataGridView1.DataSource = table;
            table.Clear();


            string status;
            foreach (var student in StudentDL.studentsList)
            {
                if (student.Status == 5)
                {
                    status = "active";
                }
                else
                {
                    status = "inactive";
                }
                table.Rows.Add(student.FirstName, student.LastName, student.Contact, student.Email, student.RegistrationNumber, status);
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set the entire row as read-only
            foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cell.ReadOnly = true;
            }
        }
    }
}
