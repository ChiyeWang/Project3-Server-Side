using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using MembersLibrary;
namespace Project3
{
    public partial class DateRequests : System.Web.UI.Page
    {
        static DBConnect objDB = new DBConnect();
        static DataSet ds = objDB.GetDataSet("SELECT * FROM DateRequest");
        static String username;
        String requestIDString = "";
        int requestID = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Username"] = "Alphonse"; //DEBUG ACCOUNT
            
            username = Session["Username"].ToString();
            bindData();
        }

        protected void bindData()
        {
            gvSent.DataSource = DateRequestClass.getSentRequests(username);
            gvSent.DataBind();
            gvReceived.DataSource = DateRequestClass.getReceivedRequests(username);
            gvReceived.DataBind();
            gvActive.DataSource = DateRequestClass.getActiveDates(username);
            gvActive.DataBind();
        }
        protected void gvActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            String requestIDString = gvActive.SelectedRow.Cells[0].ToString();
            Session["RequestID"] = requestIDString;
            Response.Redirect("~/DateRequestSetup.aspx");
            //Response.Write("ID STRING: "+requestIDString);
        }

        protected void gvReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestIDString = gvReceived.SelectedRow.Cells[0].ToString();
            requestID = Convert.ToInt32(requestIDString);
        }

        protected void btnDecline_Click(object sender, EventArgs e)
        {
            DateRequestClass.rejectDate(requestID);
            //Response.Redirect("~/DateRequests.aspx");
            bindData();

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            DateRequestClass.acceptDate(Convert.ToInt32(requestID));
            //Response.Redirect("~/DateRequests.aspx");
            bindData();
        }
    }
}