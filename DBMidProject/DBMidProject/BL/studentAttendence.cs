namespace DBMidProject.BL
{
    internal class studentAttendence
    {
        public int StudentID { get; set; }
        public int AttendenceID { get; set; }
        public int AttendenceStatus { get; set; }

        public studentAttendence(int studentID, int attendenceStatus, int attendenceID)
        {
            StudentID = studentID;
            AttendenceStatus = attendenceStatus;
            AttendenceID = attendenceID;
        }
    }
}
