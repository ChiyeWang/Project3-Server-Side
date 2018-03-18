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
    public partial class IndividualConversation : System.Web.UI.Page
    {
        String conversationID;
        static DBConnect objDB = new DBConnect();
        DataSet ds = objDB.GetDataSet("SELECT * FROM Message");
        protected void Page_Load(object sender, EventArgs e)
        {
            conversationID = Session["conversationID"].ToString();
            DataSet dsMessages = objDB.GetDataSet("SELECT * FROM Message WHERE ConversationID = "+conversationID+";");
            gvMessages.DataSource = dsMessages;
            gvMessages.DataBind();
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            CommunicationClass.InsertMessage(Session[""].ToString(),Session["conversationID"].ToString(),txtSendMessage.Text);
            txtSendMessage.Text = "";
        }

    }
}