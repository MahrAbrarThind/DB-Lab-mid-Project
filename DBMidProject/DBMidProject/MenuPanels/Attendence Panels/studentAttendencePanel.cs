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

namespace DBMidProject.MenuPanels.Attendence_Panels
{
    public partial class studentAttendencePanel : UserControl
    {
        DataTable table = new DataTable();
        public studentAttendencePanel()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void studentAttendencePanel_Load(object sender, EventArgs e)
        {
            Configuration.LoadDataFromDb();
            InitializeDataTable();
            addDataToGrid();
            AddCheckBoxColumn();
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


        private void AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "CheckBoxColumn";
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns.Insert(0,checkBoxColumn);
            dataGridView1.AllowUserToAddRows = false;
            
        }

        List<string> selectedRegistrationNumbers = new List<string>();

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["CheckBoxColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chkCell = dataGridView1.Rows[e.RowIndex].Cells["CheckBoxColumn"] as DataGridViewCheckBoxCell;
                chkCell.Value = !Convert.ToBoolean(chkCell.Value); // Toggle the checkbox value

                string registrationNumber = dataGridView1.Rows[e.RowIndex].Cells["Registration No"].Value.ToString();

                if (chkCell.Value.Equals(true))
                {
                    // If checkbox is checked, add the registration number to the list
                    selectedRegistrationNumbers.Add(registrationNumber);
                }
                else
                {
                    // If checkbox is unchecked, remove the registration number from the list
                    selectedRegistrationNumbers.Remove(registrationNumber);
                }
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cell.ReadOnly = true;
            }
        }

        private void attendenceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attendenceBtn_Click(object sender, EventArgs e)
        {
            bool isChecked = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value))
                {
                    isChecked = true;
                    break;
                }
            }

            if (!isChecked)
            {
                MessageBox.Show("Please select at least one student to mark attendance.");
                return;
            }

            if (attendenceComboBox.Text.Trim() != "")
            {
                    int status = Configuration.CheckStatus(attendenceComboBox.Text);

                    foreach (var registrationNumber in selectedRegistrationNumbers)
                    {
                        int studentID = Configuration.GetStudentIdByRegistrationNumber(registrationNumber);
                        
                        if(!((Configuration.IsStudentIdExists(studentID)) && (Configuration.IsAttendanceIdExistsInClassAttendence(Configuration.GetAttendanceIdByStudentId(studentID), dateTimePicker1.Value.Date))))
                        {
                                Configuration.insertDateInClassAttendance(dateTimePicker1.Value.Date);
                                studentAttendence attendance = new studentAttendence(studentID, status, Configuration.GetAttendanceIdByDate(dateTimePicker1.Value.Date));
                                studentAttendenceDL.add_Into_StudenctAttendenceList(attendance);
                                Configuration.InsertIntoStudentAttendenceDB(attendance);
                        }
                        else
                        {
                        MessageBox.Show("Attendance for this student already exists.");
                        break;
                        }
                    }
                
            }
            else
            {
                MessageBox.Show("Please select an attendance status.");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
