using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using MembersLibrary;
namespace Project3
{
    public partial class AllConversations : System.Web.UI.Page
    {
        static DBConnect objDB = new DBConnect();
        DataSet ds = objDB.GetDataSet("SELECT * FROM Conversation");
        protected void Page_Load(object sender, EventArgs e)
        {
            //DEBUG - USER Kristina
            String user = "Kristina";
            
            //gvAllConversations.DataSource = dsMyConversations;
            //gvAllConversations.DataBind();
        }

        protected void gvAllConversations_SelectedIndexChanged(object sender, EventArgs e)
        {
            String conversationID = gvAllConversations.Rows[gvAllConversations.SelectedIndex].Cells[2].Text;
            
            Session["conversationID"] = conversationID;
            Response.Redirect("~/IndividualConversation.aspx");
        }

        protected void btnSeeConversation_Click(object sender, EventArgs e)
        {
            
        }
    }
}