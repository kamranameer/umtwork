using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    class InsertRecords : dbConnection
    {

        public bool saveToDb(string val1, string val2,string val3,string val4, string val5, string val6, string val7, string val8, string val9)
        {
            bool _executed = false;
            using (SqlCommand cmd = new SqlCommand())
            {
                openConnection();
                cmd.CommandText = "INSERT INTO Packages VALUES (@v1, @v2, @v3,@v4,@v5,@v6,@v7,@v8,@v9)";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                /*
id
PkgName
PkgDestination
PkgStatus
trackingno
PkgDate
PkgReceiver
PkgSender
PkgReceiverAdd
PkgSenderAdd

 */
                cmd.Parameters.AddWithValue("v1", val1);
                cmd.Parameters.AddWithValue("v2", val2);
                cmd.Parameters.AddWithValue("v3", val3);
                cmd.Parameters.AddWithValue("v4", val4);
                cmd.Parameters.AddWithValue("v5", val5);
                cmd.Parameters.AddWithValue("v6", val6);
                cmd.Parameters.AddWithValue("v7", val7);
                cmd.Parameters.AddWithValue("v8", val8);
                cmd.Parameters.AddWithValue("v9", val9);
                try
                {
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        _executed = true;
                    }
                    else
                    {
                        _executed = false;
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Something wrong happened in the InsertRecord Module :", ex);
                }
                finally
                {
                    closeConnection();
                }
            }
            return _executed;

        }
    }
        class InsertNewRecord : InsertRecords
    {
    }
}
