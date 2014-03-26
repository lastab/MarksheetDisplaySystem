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
        private string strsql;
        private DataTable dt = new DataTable();
        public int Roll
        {
            get { return _roll; }
            set { _roll = value; }
        }


        //To load those students' roll who have been provided with marks
        public DataTable Get_Student_Roll_With_Marks()
        {
            strsql = "select distinct Student_Roll from student_marks";
            dt = db.Get_records(strsql);
            return dt;
        }


        //To generate students Marks
        public DataTable Get_Student_Marks()
        {
            strsql = "select sub_code, sub_name, credit_hr,attandance,assignment,term_test_i,term_test_ii,total_theory,practical,gpa from view_marks where student_roll=" + _roll;
            dt = db.Get_records(strsql);
            return dt;
        
        }

        //To delete selected studnet's selected subject marks
        public void delete_Marks(string subcode)
        {
            strsql = " delete from student_marks where student_roll="+_roll +" and subject_code='"+subcode +"';";
            db.DB_Execute(strsql);

        }

        //Calculate Total Credit
        public int Clc_total_credit()
        {
            strsql = "select sum(credit_hr) from view_marks where student_roll=" + _roll + ";";
            return Convert.ToInt16 (db.DB_GetAValue (strsql));
        }

        //Calculate Total Honor Points
        public Double Clc_total_honor_point()
        {
            strsql = "select sum(honor_point) from view_marks where student_roll=" + _roll + ";";
            return Convert.ToDouble (db.DB_GetAValue(strsql));
        }

    }
}
