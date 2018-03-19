using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace MembersLibrary
{
    public static class DateRequestClass
    {
        static DBConnect objDB = new DBConnect();
        static DataSet ds = objDB.GetDataSet("SELECT * FROM DateRequests");
        public static SqlCommand objCommand = new SqlCommand();
        public static void newRequest(String sender, String receiver)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "NewRequest"; //ADD
            objCommand.Parameters.AddWithValue("Sender", sender);
            objCommand.Parameters.AddWithValue("Receiver", receiver);
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static void rejectDate(int requestID)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "RejectDateRequest"; //ADD
            objCommand.Parameters.AddWithValue("RequestID", requestID);
            objDB.GetDataSetUsingCmdObj(objCommand);
            //String result = "";
        }
        public static void acceptDate(int requestID)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AcceptDateRequest"; //ADD
            objCommand.Parameters.AddWithValue("RequestID", requestID);
            objDB.GetDataSetUsingCmdObj(objCommand);
            //String result = "";
        }
        public static void updateDateTimeLocation(String requestID, String date, String time, String Location)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateDate"; //ADD
            objCommand.Parameters.AddWithValue("@theRequestID", Convert.ToInt32(requestID));
            objCommand.Parameters.AddWithValue("@theDate", date);
            objCommand.Parameters.AddWithValue("@theTime", time);
            objCommand.Parameters.AddWithValue("@theLocation", Location);
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static void getReceivedRequests(String member)
        {

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReceivedRequests"; //ADD
            objCommand.Parameters.AddWithValue("@user", member);
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

    }
}
