using DBMidProject.BL;
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
    public partial class updateStudentsPanel : UserControl
    {
        DataTable table = new DataTable();
        public updateStudentsPanel()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidationsClass.ValidateFields(fNameTxtBox.Text, lNameTxtBox.Text, contactTxtBox.Text, emailTxtBox.Text, RNumberTxtBox.Text, statusComboBox.Text))
            {
                string f_Name = fNameTxtBox.Text;
                string l_Name = lNameTxtBox.Text;
                string contact = contactTxtBox.Text;
                string email = emailTxtBox.Text;
                string R_Number = RNumberTxtBox.Text;
                int status = Configuration.CheckStatus(statusComboBox.Text);


                if (StudentDL.chek_R_Number(R_Number))
                {
                    StudentBL student = new StudentBL(f_Name, l_Name, contact, email, R_Number, status);
                    StudentDL.update_Into_List(student);
                    Configuration.UpdateStudentInDb(student);
                    addDataToGrid();
                    emptyTextBoxes();
                }
                else
                {
                    MessageBox.Show("Registration No Could Not Be Found");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string firstName = Convert.ToString(selectedRow.Cells["FirstName"].Value);
                string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                string contact = Convert.ToString(selectedRow.Cells["Contact"].Value);
                string email = Convert.ToString(selectedRow.Cells["Email"].Value);
                string registrationNumber = Convert.ToString(selectedRow.Cells["Registration No"].Value);
                string status = Convert.ToString(selectedRow.Cells["Status"].Value);

                fNameTxtBox.Text = firstName;
                lNameTxtBox.Text = lastName;
                contactTxtBox.Text = contact;
                emailTxtBox.Text = email;
                RNumberTxtBox.Text = registrationNumber;
                statusComboBox.Text = status;

                    // Set the entire row as read-only
                    foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                    {
                        cell.ReadOnly = true;
                    }

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

        private void updateStudentsPanel_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            Configuration.LoadDataFromDb();
            addDataToGrid();
        }
    }
}
