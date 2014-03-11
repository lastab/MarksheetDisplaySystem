using System;
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
                string strsql = "insert into Subject (Subject_Code, Subject_Name,Credit_Hour,Practical) values('" + _SubjectCode + "','" + _SubjectName + "'," + _CreditHour + "," + _HasPractical + ")";
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
                string strsql = "update Subject set Subject_Code='" + _SubjectCode +  "',Credit_Hour=" + _CreditHour + ",Practical=" + _HasPractical + " where Subject_Name='" + _SubjectName +"';";
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
