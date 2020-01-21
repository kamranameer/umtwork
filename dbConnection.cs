using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//For connecting to sql database.
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace WindowsFormsApplication2
{
   public abstract class dbConnection
    {
        //to form connection and hold variables.
        public SqlConnection conn;
        public SqlTransaction transaction;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //form a connection to the database.
        public dbConnection()  // constructor Function
        {
           
          //  string strconn = "Data Source=(localdb)\\Projects;Initial Catalog=PostOffice;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
           string strconn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PostOffice;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(strconn);
        }
        //open new connection
        public void openConnection() // new database connection yahan.
        {
            conn.Close();
            conn.Open();
            transaction = conn.BeginTransaction();
        }

        //close existing connection
        public void closeConnection() // database connection close
        {
            transaction.Commit();
            conn.Close();
        }

        //on sql error
        public void errorTransaction()
        {
            transaction.Rollback();
            conn.Close();
        }

        //execute a sql query
        protected void ExecuteSQL(string sSQL)
        {
            SqlCommand cmdDate = new SqlCommand(" SET DATEFORMAT dmy", conn, transaction);
            cmdDate.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand(sSQL, conn, transaction);
            cmd.ExecuteNonQuery();
        }

        protected void OnlyExecuteSQL(string sSQL)
        {
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();
        }

        protected DataSet FillData(string sSQL, string sTable)
        {
            SqlCommand cmd = new SqlCommand(sSQL, conn, transaction);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, sTable);
            return ds;
        }

        protected SqlDataReader setDataReader(string sSQL)
        {
            SqlCommand cmd = new SqlCommand(sSQL, conn, transaction);
            cmd.CommandTimeout = 300;
            SqlDataReader rtnReader;
            rtnReader = cmd.ExecuteReader();
            return rtnReader;
        } 
    }

   //class <derived_class> : <base_class>
   class dbProcess : dbConnection
   {
   }


}
