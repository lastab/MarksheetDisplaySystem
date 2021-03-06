﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Marksheet
{
    class class_subject_details
    {
        database db = new database();
        
        private string _SubjectCode;
        private string _SubjectName;
        private int  _CreditHour;
        private Boolean _HasPractical;
        private string strsql;

        public string SubjectCode
        {
            get
            {
                return _SubjectCode;
            }
            set
            {
                _SubjectCode  = value;
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
        public int CredtHour
        {
            get
            {
                return _CreditHour;
            }
            set
            {
                _CreditHour = value;
            }
        }
        public Boolean HasPractical
        {
            get
            {
                return _HasPractical;
            }
            set
            {
                _HasPractical = value;
            }
        }
        
        /// <summary>
        /// Procedures
        /// </summary>
        public string Add_Subject_Details()
        {
            try
            {
                string strsql = "insert into Subject (Subject_Code, Subject_Name,Credit_Hour,has_Practical) values('" + _SubjectCode + "','" + _SubjectName + "'," + _CreditHour + "," + _HasPractical + ")";
                db.DB_Execute(strsql);
                return "inserted";
            }
            catch
            {
                return "update";
            }
        }
        public string Update_Subject_Details()
        {
            try
            {
                string strsql = "update Subject set Subject_Name='" + _SubjectName  +  "',Credit_Hour=" + _CreditHour + ",has_Practical=" + _HasPractical + " where Subject_Code='" + _SubjectCode  +"';";
                db.DB_Execute(strsql);
                return "updated";
            }
            catch
            {
                return "fail";
            }
        }

        public string Delete_Subject_Details()
        {
            try
            {
                string strsql = "delete from Subject where Subject_Code='" + _SubjectCode + "';";
                db.DB_Execute(strsql);
                return "Deleted";
            }
            catch
            {
                return "fail";
            }
        }

        public DataTable Get_All_Subject_Details()
        {
            DataTable dt = new DataTable();
            strsql = "select * from Subject;";
            dt = db.Get_records(strsql);
            return dt;

        }
    }
}
