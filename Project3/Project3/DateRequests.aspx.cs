using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using MembersLibrary;
namespace Project3
{
    public partial class DateRequests : System.Web.UI.Page
    {
        static DBConnect objDB = new DBConnect();
        static DataSet ds = objDB.GetDataSet("SELECT * FROM DateRequest");

        protected void Page_Load(object sender, EventArgs e)
        {
            gvSent.DataSource = DateRequestClass.getSentRequests("Kristina");
            gvSent.DataBind();
            gvReceived.DataSource = DateRequestClass.getReceivedRequests("Kristina");
            gvReceived.DataBind();
            
        }
    }
}