namespace DBMidProject.BL
{
    public class StudentBL
    {
        string f_Name;
        string l_Name;
        string contact;
        string email;
        string R_Number;
        int status;

        public StudentBL(string f_Name, string l_Name, string contact, string email, string R_Number, int status)
        {
            this.f_Name = f_Name;
            this.l_Name = l_Name;
            this.contact = contact;
            this.email = email;
            this.R_Number = R_Number;
            this.status = status;
        }
       

        public string FirstName
        {
            get { return f_Name; }
            set { f_Name = value; }
        }

        public string LastName
        {
            get { return l_Name; }
            set { l_Name = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string RegistrationNumber
        {
            get { return R_Number; }
            set { R_Number = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
