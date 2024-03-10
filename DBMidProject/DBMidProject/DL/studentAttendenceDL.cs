using DBMidProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMidProject.DL
{
    internal class studentAttendenceDL
    {
        public static List<studentAttendence> studentAttendenceList = new List<studentAttendence>();

        public static void add_Into_StudenctAttendenceList(studentAttendence attendence)
        {
            studentAttendenceList.Add(attendence);
        }
    }
}
