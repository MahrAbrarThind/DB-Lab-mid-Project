using DBMidProject.BL;
using DBMidProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class AddstudentsPanel : UserControl
    {
        DataTable table = new DataTable();

        public AddstudentsPanel()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void fNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidationsClass.ValidateFields(fNameTxtBox.Text, lNameTxtBox.Text, contactTxtBox.Text, emailTxtBox.Text, RNumberTxtBox.Text, statusComboBox.Text))
            {
                string f_Name = fNameTxtBox.Text;
                string l_Name = lNameTxtBox.Text;
                string contact = contactTxtBox.Text;
                string email = emailTxtBox.Text;
                string R_Number = RNumberTxtBox.Text;
                int status = Configuration.CheckStatus(statusComboBox.Text);

                if (!StudentDL.chek_R_Number(R_Number))
                {
                    StudentBL student = new StudentBL(f_Name, l_Name, contact, email, R_Number, status);
                    StudentDL.add_Student_Into_List(student);
                    Configuration.insertInDb(student);
                    /*Configuration.LoadDataFromDb();*/
                    MessageBox.Show("Data Added Successfully To Database");
                    addDataToGrid();
                }
                else
                {
                    MessageBox.Show("Registration No Already Exists");
                }
                emptyTextBoxes();
            }
        }


        private void studentsPanel_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            Configuration.LoadDataFromDb();
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

        private void emptyTextBoxes()
        {
            fNameTxtBox.Text = "";
            lNameTxtBox.Text = "";
            contactTxtBox.Text = "";
            emailTxtBox.Text = "";
            RNumberTxtBox.Text = "";
            statusComboBox.SelectedIndex = -1;
        }
    }
}

