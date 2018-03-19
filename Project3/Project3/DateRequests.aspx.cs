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
            if (!IsPostBack) {
                //Session["User"] = "Ed"; //DEBUG ACCOUNT

                username = Session["User"].ToString();
                bindData();
            }
            
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
            requestIDString = gvActive.SelectedRow.Cells[0].Text;
            Session["RequestID"] = requestIDString;
            //Response.Redirect("~/DateRequestSetup.aspx");
            //Response.Write("ID STRING: "+requestIDString);
        }

        protected void gvReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestIDString = gvReceived.SelectedRow.Cells[0].Text;
            requestID = Convert.ToInt32(requestIDString); //DEBUG HERE
            
        }



        protected void gvReceived_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //requestID = Convert.ToInt32(gvReceived.SelectedRow.Cells[0].Text);
            if(e.CommandName == "Accept")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                //requestIDString = gvReceived.SelectedRow.Cells[0].Text;
                requestIDString = gvReceived.Rows[rowIndex].Cells[0].Text;
                requestID = Convert.ToInt32(requestIDString); //DEBUG HERE
                DateRequestClass.acceptDate(requestID);
                bindData();
            }
            else
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                //requestIDString = gvReceived.SelectedRow.Cells[0].Text;
                requestIDString = gvReceived.Rows[rowIndex].Cells[0].Text;
                requestID = Convert.ToInt32(requestIDString); //DEBUG HERE
                DateRequestClass.rejectDate(requestID);
                bindData();
            }
        }

        protected void gvActive_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SeeConversation")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                requestIDString = gvActive.Rows[rowIndex].Cells[0].Text;
                //DataSet getRequestID = DateRequestClass.getActiveDates(username);


                // requestID = Convert.ToInt32(requestIDString); //DEBUG HERE
                Session["RequestID"] = requestIDString;
                
                //Response.Write(requestIDString);
                //Response.Redirect("~/DateRequestSetup.aspx");
                //DateRequestClass.acceptDate(requestID);
                //bindData();
            }
        }
    }
}