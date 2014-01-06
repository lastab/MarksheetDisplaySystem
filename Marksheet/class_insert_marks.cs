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
        /// <summary>
        /// Procedures
        /// </summary>
        public void Add_Student_Marks()
        {
            string strsql = "insert into Student_marks (Subject_Name,Student_Roll,attandance,Assignment,Term_Test,Practical) values('" + _SubjectName + "'," + _Roll + "," + _Attendance + "," + _Assignment + "," + _TermTest + "," + _Practical + ")";
            db.DB_Execute(strsql);
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

    }
}
