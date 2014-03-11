using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Marksheet
{
    class class_insert_marks
    {

        database db = new database();
        private int _Roll;
        private string _SubjectName;
        private int _Attendance;
        private int _Assignment;
        private int _TermTest;
        private int _Practical;
        private int _TotalMarks;

        public int Roll
        {
            get
            {
                return _Roll;
            }
            set
            {
                _Roll = value;
            }
        }

        public string SubjectName
        {
            get
            {
                return _SubjectName;
            }
            set
            {
                _SubjectName = value;
            }
        }
        public int Attendance
        {
            get
            {
                return _Attendance;
            }
            set
            {
                _Attendance  = value;
            }
        }
        public int Assignment
        {
            get
            {
                return _Assignment ;
            }
            set
            {
                _Assignment  = value;
            }
        }
        public int TermTest
        {
            get
            {
                return _TermTest;
            }
            set
            {
                _TermTest = value;
            }
        }
        public int Practical
        {
            get
            {
                return _Practical;
            }
            set
            {
                _Practical = value;
            }
        }
        public int TotalMarks
        {
            get
            {
                return _TotalMarks;
            }
            set
            {
                _TotalMarks = value;
            }
        }
        /// <summary>
        /// Procedures
        /// </summary>
        /// 
        public void Calculate_Total()
        {
            if (Subject_Has_practical() == "True")
            {
                _TotalMarks = _Assignment + _Attendance + TermTest + _Practical;
            }
            else
            {
                _TotalMarks = _Assignment + _Attendance + TermTest;
                _TotalMarks = _TotalMarks / 90 * 100;
            }
        }

        public string Add_Student_Marks()
        {
            try
            {
                string strsql = "insert into Student_marks (Subject_Name,Student_Roll,Attandance,Assignment,Term_Test,Practical,Total_Percent) values('" + _SubjectName + "'," + _Roll + "," + _Attendance + "," + _Assignment + "," + _TermTest + "," + _Practical + "," + _TotalMarks  + ")";
                db.DB_Execute(strsql);
                return "inserted";
            }
            catch
            {
                return "update";
            }
        }
        public string Update_Student_Marks()
        {
            try
            {
                string strsql = "update Student_Marks set Attandance=" + _Attendance + ",Assignment=" + _Assignment + ",Term_Test=" + _TermTest + ",Practical=" + _Practical + ",Total_Percent=" + _TotalMarks + " where Subject_Name='" + _SubjectName + "' and Student_Roll=" + _Roll + ";";
                db.DB_Execute(strsql);
                return "updated";
            }
            catch 
            {
                return "fail";
            }
        }
        public DataTable Get_All_Student_Roll()
        {
            DataTable dt = new DataTable();
            string strsql = "select Student_Roll from student";
            dt=db.Get_records(strsql);
            return dt;
        }

        public DataTable Get_All_Subjects()
        {
            DataTable dt = new DataTable();
            string strsql = "select Subject_Name from subject";
            dt = db.Get_records(strsql);
            return dt;
        }

        public string Subject_Has_practical()
        {
            return db.DB_GetAValue("select practical from Subject where Subject_Name='" + _SubjectName + "';");
        }

    }
}
