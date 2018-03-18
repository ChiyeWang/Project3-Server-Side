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
    class DateRequestClass
    {
        static DBConnect objDB = new DBConnect();
        DataSet ds = objDB.GetDataSet("SELECT * FROM DateRequests");
        public static SqlCommand objCommand = new SqlCommand();
        public static void newRequest()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static void updateRequestStatus()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
            String result = "";
        }

        public static void updateDateTimeLocation(String requestID, String date, String time, String Location)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

    }
}
