using DBMidProject.BL;
using DBMidProject.DL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    internal class Configuration
    {
        public static string SqlConnectionString = "Data Source=DESKTOP-6US4BR2;Initial Catalog=ProjectB;Integrated Security=True;Encrypt=False";



        public static void insertInDb(StudentBL student)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {

                connection.Open();
                try
                {

                    string query = "INSERT INTO Student (FirstName, LastName, Email, RegistrationNumber, Contact, Status) " +
                              "VALUES (@FirstName, @LastName, @Email, @RegistrationNumber, @Contact, @Status)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);
                    command.Parameters.AddWithValue("@Contact", student.Contact);
                    command.Parameters.AddWithValue("@Status", student.Status);
                    command.ExecuteNonQuery();

                    /* return true;*/

                }
                catch (Exception ex)
                {

                    MessageBox.Show("exception occured" + ex.Message);
                }
                /* return false;*/
            }
        }
        public static int CheckStatus(string status)
        {
            int statusId = -1;

            string query = "SELECT LookupId FROM Lookup WHERE Name = @StatusName";

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StatusName", status);

                        object result = command.ExecuteScalar();

                        // If status ID is retrieved successfully, convert it to integer
                        if (result != null && result != DBNull.Value)
                        {
                            statusId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occurred while checking status: " + ex.Message);
                }
            }

            return statusId;
        }

        public static void LoadDataFromDb()
        {
            // Initialize list of students
            /*List<StudentBL> students = new List<StudentBL>();*/
            StudentDL.studentsList.Clear();
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0); 
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);
                            string contact = reader.GetString(3);
                            string email = reader.GetString(4);
                            string registrationNumber = reader.GetString(5);
                            int status = reader.GetInt32(6);

                           StudentDL.studentsList.Add(new StudentBL(firstName, lastName, contact, email, registrationNumber, status));
                        }
                    }
                }
            }
        }


        public static void UpdateStudentInDb(StudentBL student)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                string updateQuery = "UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = @Status WHERE RegistrationNumber = @RegistrationNumber ";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Contact", student.Contact);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);
                    command.Parameters.AddWithValue("@Status", student.Status);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Added Successfully To Database");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }


        public static void DeleteStudentFromDb(string registrationNumber)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                string updateQuery = "UPDATE Student SET Status = 6 WHERE RegistrationNumber = @RegistrationNumber";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Student not found with the given registration number.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }


        public static void insertDateInClassAttendance(DateTime currentDate)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();
                try
                {
                    // Check if the date already exists in the database
                    string checkQuery = "SELECT COUNT(*) FROM ClassAttendance WHERE AttendanceDate = @AttendanceDate";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@AttendanceDate", currentDate);

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        /*return false;*/ // Exit the method without inserting the date
                    }

                    // If the date does not exist, insert it into the database
                    string insertQuery = "INSERT INTO ClassAttendance (AttendanceDate) VALUES (@Attendance)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Attendance", currentDate);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Attendance date inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occurred: " + ex.Message);
                }
/*                return true;
*/            }
        }


        public static int GetAttendanceIdByDate(DateTime currentDate)
        {
            int attendanceId = -1; // Initialize the ID variable

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = @AttendanceDate";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AttendanceDate", currentDate);

                    // Execute the query to retrieve the ID
                    object result = command.ExecuteScalar();

                    // If result is not null, convert it to integer
                    if (result != null && result != DBNull.Value)
                    {
                        attendanceId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occurred: " + ex.Message);
                }
            }

            return attendanceId;
        }

        public static int GetStudentIdByRegistrationNumber(string registrationNumber)
        {
            int studentId = -1; // Default value if not found

            string query = "SELECT Id FROM Student WHERE RegistrationNumber = @RegistrationNumber";

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);

                        object result = command.ExecuteScalar();

                        // If student ID is retrieved successfully, convert it to integer
                        if (result != null && result != DBNull.Value)
                        {
                            studentId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occurred while fetching student ID: " + ex.Message);
                }
            }

            return studentId;
        }


        public static void InsertIntoStudentAttendenceDB(studentAttendence attendance)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();
                try
                {
                        string query = "INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) " +
                                       "VALUES (@AttendanceId, @StudentId, @AttendanceStatus)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@AttendanceId", attendance.AttendenceID);
                        command.Parameters.AddWithValue("@StudentId", attendance.StudentID);
                        command.Parameters.AddWithValue("@AttendanceStatus", attendance.AttendenceStatus);
                        command.ExecuteNonQuery();

                    MessageBox.Show("Student attendance data inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occurred: " + ex.Message);
                }
            }
        }

        public static bool IsStudentIdExists(int studentId)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT COUNT(*) FROM StudentAttendance WHERE StudentId = @StudentId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    exists = (count > 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occurred: " + ex.Message);
                }
            }

            return exists;
        }

        public static int GetAttendanceIdByStudentId(int studentId)
        {
            int attendanceId = -1; // Default value if not found

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT AttendanceId FROM StudentAttendance WHERE StudentId = @StudentId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        attendanceId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occurred: " + ex.Message);
                }
            }

            return attendanceId;
        }

        public static bool IsAttendanceIdExistsInClassAttendence(int attendanceId,DateTime date)
        {
            bool exists = false; // Initialize the exists variable

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();
                try
                {
                    string query = "SELECT COUNT(*) FROM ClassAttendance WHERE Id = @AttendanceId and AttendanceDate=@date";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AttendanceId", attendanceId);
                    command.Parameters.AddWithValue("@date", date);

                    // Execute the query to count the occurrences of the ID
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    exists = (count > 0); // Set exists to true if count is greater than 0
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occurred: " + ex.Message);
                }
            }

            return exists;
        }


    }
}
