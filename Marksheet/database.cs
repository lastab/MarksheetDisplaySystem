using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Marksheet
{
    class database
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter Data_adapter = new OleDbDataAdapter();

        //Procedure to connect the databas
        private void Connect_to_database()
        {
            conn.ConnectionString = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source= marksheet.mdb; Jet OLEDB:Database Password=cosmos";
            conn.Open();
        }

        // Procedure to get all records from selected table
        public DataTable Get_all_records(string Table_name)
        {
            DataTable Dt = new DataTable();
            Connect_to_database();
            cmd.CommandText = "Select * from " + Table_name;
            cmd.Connection = conn;
            Data_adapter.SelectCommand = cmd;
            Data_adapter.Fill(Dt);
            conn.Close();
            return Dt;
        }

        // Procedure to get records from selected command
        public DataTable Get_records(string strsql)
        {
            DataTable Dt = new DataTable();
            Connect_to_database();
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            Data_adapter.SelectCommand = cmd;
            Data_adapter.Fill(Dt);
            conn.Close();
            return Dt;
        }

        //Procedure to execute add, edit or delte records in table 
        public void DB_Execute(string strsql)
        {
            try
            {
                Connect_to_database();
                cmd.CommandText = strsql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                conn.Close();
                throw ex;
            }
        }

        //Procedure to return string Valuefrom passed sql statement
        public string DB_GetAValue(string strsql)
        {
            string retval;
            Connect_to_database();
            cmd.CommandText = strsql;
            cmd.Connection = conn;
            retval = cmd.ExecuteScalar().ToString();
            conn.Close();
            return retval;
        }

    }

}
