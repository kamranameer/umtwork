using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    class dbLogUser : dbConnection
    {
        public int LoginID
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
        public bool ValidRegLogUser()
        {
            bool _UserValid = false;
            using (SqlCommand cmd = new SqlCommand())
            {
                openConnection(); 
                SqlDataReader conReader; 
                conReader = null;
                cmd.CommandText = "Select * from Users where UserName=@userName and Password=@UserPassword";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = Password;
                try
                {
                    conReader = cmd.ExecuteReader();
                    while (conReader.Read())
                    {
                        LoginID = Convert.ToInt32(conReader["LoginID"]);
                        Role = Convert.ToString(conReader["Role"]);
                        _UserValid = true;
                    }
                }
                catch (Exception ex)
                {
                    errorTransaction();
                    throw new ApplicationException("Something wrong happened in the Login module :", ex);
                }
                finally
                {
                    conReader.Close(); closeConnection();
                }
            }
            return _UserValid;
        }
    }
    class dbUser : dbLogUser
    {
    }
}
