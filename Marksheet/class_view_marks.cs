using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Marksheet
{
    class class_view_marks
    {
        database db = new database();

        private int _roll;
        public int Roll
        {
            get { return _roll; }
            set { _roll = value; }
        }


        //To load those students' roll who have been provided with marks
        public DataTable Get_Student_Roll_With_Marks()
        {
            DataTable dt = new DataTable();
            string strsql = "select distinct Student_Roll from student_marks";
            dt = db.Get_records(strsql);
            return dt;
        }


        //To generate students Marks
        public DataTable Get_Student_Marks()
        {
            DataTable dt = new DataTable();
            string strsql = "select subject_code, subject_name, credit_hour,attandance,assignment,term_test,practical,total_percent from view_marks where student_roll=" + _roll;
            dt = db.Get_records(strsql);
            return dt;
        
        }

    }
}
