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
        private Boolean _Gender;
        private DateTime _DOB;
        private string _Address;
        private string _Phone;

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
        public Boolean Gender
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
                string strsql = "insert into Student (Student_Roll,Student_Name,Gender,Dob,Address,Phone) values(" + _Roll + ",'" + _FName + " " + _LName + "'," + _Gender + ",'" + _DOB + "','" + _Address + "','" + _Phone + "')";


                db.DB_Execute(strsql);
                return "inserted";
            }
            catch (OleDbException ex)
            {
                return "update";
            }
        }
        public string Update_Student_Details()
        {
            try
            {
                string strsql = "update Student set Student_Name='" + _FName + " " + _LName + "',Gender=" + _Gender + ",Dob='" + _DOB + "',Address='" + _Address + "',Phone='" + _Phone + "' where Student_Roll=" + _Roll + ";";
                db.DB_Execute(strsql);
                return "updated";
            }
            catch (OleDbException ex)
            {
                return "fail";

            }



        }



    }
}
