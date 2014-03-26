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
        private string _SubjectCode;
        private float  _Attendance;
        private float  _Assignment;
        private float _TermTestI;
        private float _TermTestII;
        private float _Practical;
        private float _TotalTheory;
        private string _Gpa;
        private Double   _HonorPoint;

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
        public string SubjectCode
        {
            get
            {
                return _SubjectCode;
            }
            set
            {
                _SubjectCode = value;
            }
        }
        public float Attendance
        {
            get
            {
                return _Attendance;
            }
            set
            {
                _Attendance = value;
            }
        }
        public float Assignment
        {
            get
            {
                return _Assignment;
            }
            set
            {
                _Assignment = value;
            }
        }
        public float TermTestI
        {
            get
            {
                return _TermTestI;
            }
            set
            {
                _TermTestI = value;
            }
        }
        public float TermTestII
        {
            get
            {
                return _TermTestII;
            }
            set
            {
                _TermTestII = value;
            }
        }

        public float Practical
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
        public float TotalTheory
        {
            get
            {
                return _TotalTheory;
            }
            set
            {
                _TotalTheory = value;
            }
        }
        public string GPA
        {
            get
            {
                return _Gpa;
            }
            set
            {
                _Gpa = value;
            }
        }

        public Double   HonorPoint
        {
            get
            {
                return _HonorPoint;
            }
            set
            {
                _HonorPoint = value;
            }
        }

        /// <summary>
        /// Procedures
        /// </summary>
        /// 


        public string Add_Student_Marks()
        {
            try
            {
                string strsql = "insert into Student_marks (Subject_Code,Student_Roll,Attandance,Assignment,Term_Test_i,Term_Test_ii,Practical,Total_theory,gpa,honor_point) values('" + _SubjectCode + "'," + _Roll + "," + _Attendance + "," + _Assignment + "," + _TermTestI + "," + _TermTestII + "," + _Practical + "," + _TotalTheory + ",'"+_Gpa+"',"+_HonorPoint + ")";
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
                string strsql = "update Student_Marks set Attandance=" + _Attendance + ",Assignment=" + _Assignment + ",Term_Test_i=" + _TermTestI + ",Term_Test_ii=" + _TermTestII + ",Practical=" + _Practical + ",Total_theory=" + _TotalTheory +",gpa='" + _Gpa + "',honor_point=" + _HonorPoint+ " where Subject_Code='" + _SubjectCode + "' and Student_Roll=" + _Roll + ";";
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
            dt = db.Get_records(strsql);
            return dt;
        }

        public DataTable Get_All_Subjects()
        {
            DataTable dt = new DataTable();
            string strsql = "select Subject_Name,subject_code from subject Order by Subject_Name";
            dt = db.Get_records(strsql);
            return dt;
        }

        public string Subject_Has_practical()
        {
            return db.DB_GetAValue("select has_practical from Subject where Subject_Code='" + _SubjectCode + "';");
        }

        public void Calculate_Total()
        {
            float grandTotal;
            _TotalTheory = _Assignment + _Attendance + TermTestI + TermTestII;
            if (Subject_Has_practical() == "true")
                grandTotal = (_TotalTheory + _Practical) / 110 * 100;
            else
                grandTotal = _TotalTheory;
            if (grandTotal > 90)
            {
                _Gpa = "A";
                _HonorPoint=4.0;
            }
            else if (grandTotal > 85)
            {
                _Gpa = "A-";
                _HonorPoint = 3.7;
            }
            else if (grandTotal > 80)
            {
                _Gpa = "B+";
                _HonorPoint = 3.3;
            }
            else if (grandTotal > 75)
            {
                _Gpa = "B";
                _HonorPoint = 3.0;
            }
            else if (grandTotal > 70)
            {
                _Gpa = "B-";
                _HonorPoint = 2.7;
            }
            else if (grandTotal > 65)
            {
                _Gpa = "C+";
                _HonorPoint = 2.3;
            }
            else if (grandTotal > 60)
            {
                _Gpa = "C";
                _HonorPoint = 2.0;
            }
            else if (grandTotal > 55)
            {
                _Gpa = "C-";
                _HonorPoint = 1.7;
            }
            else if (grandTotal > 50)
            {
                _Gpa = "D+";
                _HonorPoint = 1.5;
            }
            else if (grandTotal > 45)
            {
                _Gpa = "D";
                _HonorPoint = 1.0;
            }
            else 
            {
                _Gpa = "F";
                _HonorPoint = 0.0;
            }


        }

    }
}
