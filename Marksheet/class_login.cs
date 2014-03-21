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
        database db = new database();
        public string getPassword(string user)
        {
            string pass;
            pass = db.DB_GetAValue("select password from login where user_id='" + user + "';");
            return pass;
        }
    }
}
