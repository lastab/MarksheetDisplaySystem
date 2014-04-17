using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;



namespace Marksheet
{
    class class_login
    {
        private string _user;
        private string _userName;
        private string _pass;
        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string userType
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Password
        {
            set { _pass = value; }
        }
        database db = new database();
        private string getPassword()
        {
            string pass;
            pass = db.DB_GetAValue("select password from login where user_id='" + _userName + "';");
            return pass;
        }

        public Boolean  checkLoginSuccess()
        {
            if (_pass == getPassword())
                return true ;
            else
                return false ;

        }

        public void getUserType()
        { 
            userType= db.DB_GetAValue ("select user_type from login where user_id='"+userName +"'" );
        }

        public Boolean checkStudentLoginSuccess(string roll, DateTime DOB)
        {
            DateTime checkDOB = Convert .ToDateTime ( db.DB_GetAValue("select DOB from student where student_roll=" + roll));
            
            if (checkDOB.ToShortDateString ()  == DOB.ToShortDateString ())
                return true;
            else
                return false;
        }
    }
}
