using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    class tracking : dbConnection
    {
        public string TrackingNo
        {
            get;
            set;
        }
        public string PackageName
        {
            get;
            set;
        }
        public string PackageDate
        {
            get;
            set;
        }
        public string PackageStatus
        {
            get;
            set;
        }
        public string PackageDestination
        {
            get;
            set;
        }
        public string PackageReceiver
        {
            get;
            set;
        }
        public string PackageSender
        {
            get;
            set;
        }
        public string PackageReceiverAddress
        {
            get;
            set;
        }
        public string PackageSenderAddress
        {
            get;
            set;
        }
        public  bool GetTrackingInfo()
        {
            bool _tracked = false;
            using (SqlCommand cmd = new SqlCommand())
            {
                openConnection();
                SqlDataReader conReader;
                conReader = null;
                cmd.CommandText = "Select * from Packages where trackinno=@trackNo";
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@trackNo", SqlDbType.VarChar).Value = TrackingNo;
                try
                {
                    conReader = cmd.ExecuteReader();
                    while (conReader.Read())
                    {
                        _tracked = true;
                        PackageName = Convert.ToString(conReader["PkgName"]);
                        PackageDestination = Convert.ToString(conReader["PkgDestination"]);
                        PackageStatus = Convert.ToString(conReader["PkgStatus"]);
                        PackageDate = Convert.ToString(conReader["PkgDate"]);
                        PackageReceiver = Convert.ToString(conReader["PkgReceiver"]);
                        PackageSender = Convert.ToString(conReader["PkgSender"]);
                        PackageReceiverAddress = Convert.ToString(conReader["PkgReceiverAdd"]);
                        PackageSenderAddress = Convert.ToString(conReader["PkgSenderAdd"]);
                     
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
            return _tracked;
        }
    }
    class dbTrack : tracking
    {
    }
}
