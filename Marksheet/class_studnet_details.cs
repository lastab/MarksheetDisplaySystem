using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Marksheet
{
    class class_studnet_details
    {
        database db = new database();
        private int _Roll;
        private string _FName;
        private string _LName;
        private string  _Gender;
        private DateTime _DOB;
        private string _Address;
        private string _Phone;
        private string strsql;

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

        public string FName
        {
            get
            {
                return _FName;
            }
            set
            {
                _FName = value;
            }
        }
        public string LName
        {
            get
            {
                return _LName;
            }
            set
            {
                _LName = value;
            }
        }
        public string  Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                _DOB = value;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        public string Phone
        {
            get
            {
                return _Phone ;
            }
            set
            {
                _Phone = value;
            }
        }

        /// <summary>
        /// Procedures
        /// </summary>
        public string Add_Student_Details()
        {
            try
            {
                strsql = "insert into Student (Student_Roll,Student_Name,Gender,Dob,Address,Phone) values(" + _Roll + ",'" + _FName + " " + _LName + "','" + _Gender + "','" + _DOB + "','" + _Address + "','" + _Phone + "')";


                db.DB_Execute(strsql);
                return "inserted";
            }
            catch 
            {
                return "update";
            }
        }
        public string Update_Student_Details()
        {
            try
            {
                strsql = "update Student set Student_Name='" + _FName + " " + _LName + "',Gender='" + _Gender + "',Dob='" + _DOB + "',Address='" + _Address + "',Phone='" + _Phone + "' where Student_Roll=" + _Roll + ";";
                db.DB_Execute(strsql);
                return "updated";
            }
            catch
            {
                return "fail";

            }



        }


        public string Delete_Student_Details()
        {
            try
            {
                strsql = "delete from Student where Student_Roll=" + _Roll + ";";
                db.DB_Execute(strsql);
                return "deleted";
            }
            catch
            {
                return "fail";

            }



        }

        //To generate student's details
        public void  Get_Student_Details()
        {
            strsql = "select Student_Name from student where Student_Roll=" + _Roll;
            _FName  = db.DB_GetAValue (strsql);
            strsql = "select gender from student where Student_Roll=" + _Roll;
           
                _Gender = db.DB_GetAValue(strsql);
           
            strsql = "select Phone from student where Student_Roll=" + _Roll;
            _Phone = db.DB_GetAValue(strsql);

            strsql = "select Address from student where Student_Roll=" + _Roll;
            _Address  = db.DB_GetAValue(strsql);

            strsql = "select DOB from student where Student_Roll=" + _Roll;
            _DOB = Convert.ToDateTime(db.DB_GetAValue(strsql));
        }



        public DataTable Get_All_Student_Details()
        {
            DataTable dt = new DataTable();
            strsql = "select * from student;";
            dt = db.Get_records(strsql);
            return dt;

        }



    }
}
