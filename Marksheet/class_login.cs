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
        private string _pass;
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
            pass = db.DB_GetAValue("select password from login where user_id='" + _user + "';");
            return pass;
        }

        public Boolean  checkLoginSuccess()
        {
            if (_pass == getPassword())
                return true ;
            else
                return false ;

        }
    }
}
