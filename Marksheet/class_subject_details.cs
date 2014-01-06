using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Add_Subject_Details()
        {
            string strsql = "insert into Subject (Subject_Name,Credit_Hour,Practical) values('" + _SubjectName  + "'," + _CreditHour + "," + _HasPractical + ")";
            // No subject code hasf been inserted.....
            db.DB_Execute(strsql);
        }
    }
}
