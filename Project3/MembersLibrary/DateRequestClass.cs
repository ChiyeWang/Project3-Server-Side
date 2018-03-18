using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
namespace MembersLibrary
{
    class DateRequestClass
    {
        static DBConnect objDB = new DBConnect();
        DataSet ds = objDB.GetDataSet("SELECT * FROM DateRequests");

        public static void newRequest()
        {
            //String command = "INSERT INTO DateRequests ("
        }
    }
}
