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
        String user;
        protected void Page_Load(object sender, EventArgs e)
        {

            //conversationID = Session["conversationID"].ToString();
            //debug
            conversationID = "BobJen";
            user = "Bob";//DEBUG
            gvMessages.DataSource = CommunicationClass.getMessages(conversationID);
            gvMessages.DataBind();
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            String content = txtSendMessage.Text;
            CommunicationClass.insertMessage(conversationID, user, content);
        }

        protected void gvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String conversationID = gvMessages.Rows[gvMessages.SelectedIndex].Cells[3].Text;
            int messageID = Convert.ToInt32(gvMessages.Rows[gvMessages.SelectedIndex].Cells[3].Text);
            Session["conversationID"] = conversationID;
            CommunicationClass.deleteMessage(messageID);
        }

        
    }
}