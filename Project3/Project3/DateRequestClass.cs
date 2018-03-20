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
        static DataSet ds = objDB.GetDataSet("SELECT * FROM DateRequest");
        //public static SqlCommand objCommand = new SqlCommand();
        public static void newRequest(String sender, String receiver)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "NewRequest"; //ADD
            objCommand.Parameters.AddWithValue("Sender", sender);
            objCommand.Parameters.AddWithValue("Receiver", receiver);
             objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static void rejectDate(int requestID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "RejectDateRequest"; //ADD
            objCommand.Parameters.AddWithValue("RequestID", requestID);
            objDB.GetDataSetUsingCmdObj(objCommand);
            //String result = "";
        }
        public static void acceptDate(int requestID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AcceptDateRequest"; //ADD
            objCommand.Parameters.AddWithValue("RequestID", requestID);
            objDB.GetDataSetUsingCmdObj(objCommand);
            //String result = "";
        }
        public static void updateDateTimeLocation(int requestID, String date, String time, String Location)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateDate"; //ADD

            SqlParameter input = new SqlParameter("theRequestID", requestID);
            objCommand.Parameters.Add(input);
            input = new SqlParameter("theDate", date);
            objCommand.Parameters.Add(input);
            input = new SqlParameter("theTime", time);
            objCommand.Parameters.Add(input);
            input = new SqlParameter("theLocation", Location);
            objCommand.Parameters.Add(input);
            
            /*
            SqlParameter request = new SqlParameter("@theRequestID", requestID);
            request.Direction = ParameterDirection.Input;
            request.SqlDbType = SqlDbType.Int;
            request.Size = 50;
            objCommand.Parameters.Add(request);
            
            SqlParameter theDate = new SqlParameter("@theDate", date);
            theDate.Direction = ParameterDirection.Input;
            theDate.SqlDbType = SqlDbType.VarChar;
            theDate.Size = 50;
            objCommand.Parameters.Add(theDate);
            SqlParameter theTime = new SqlParameter("@theTime", time);
            theTime.Direction = ParameterDirection.Input;
            theTime.SqlDbType = SqlDbType.VarChar;
            theTime.Size = 50;
            objCommand.Parameters.Add(theTime);
            SqlParameter theLocation = new SqlParameter("@theLocation", Location);
            theLocation.Direction = ParameterDirection.Input;
            theLocation.SqlDbType = SqlDbType.VarChar;
            theLocation.Size = 50;
            objCommand.Parameters.Add(theLocation);
            
            objCommand.Parameters.Add(inputParameter);*/
            /*
            SqlParameter input = new SqlParameter("city", member.city);
            obj.Parameters.Add(input);
            input = new SqlParameter("state", member.state);
            objCommand.Parameters.AddWithValue("@theRequestID",requestID);
            objCommand.Parameters.AddWithValue("@theDate", date);
            objCommand.Parameters.AddWithValue("@theTime", time);
            objCommand.Parameters.AddWithValue("@theLocation", Location);*/
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static DataSet dateDetails(int requestID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetDateDetails"; //ADD
            objCommand.Parameters.AddWithValue("RequestID", requestID);
            return objDB.GetDataSetUsingCmdObj(objCommand);
            //String result = "";
        }

        public static DataSet getReceivedRequests(String member)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReceivedRequests"; //ADD
            objCommand.Parameters.AddWithValue("@user", member);
            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static DataSet getSentRequests(String member)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetSentRequests"; //ADD
            objCommand.Parameters.AddWithValue("@user", member);
            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static DataSet getActiveDates(String member)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetActiveDates"; //ADD
            objCommand.Parameters.AddWithValue("@user", member);
            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

    }
}
