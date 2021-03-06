﻿using System;
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
            if (!IsPostBack)
            {
                if (Session["UserType"].ToString() == "v")
                {
                    Response.Redirect("/search.aspx");
                }
                String user = Session["User"].ToString();
                gvAllConversations.DataSource = CommunicationClass.myConversation(user);
                gvAllConversations.DataBind();
            }
        }

        protected void gvAllConversations_SelectedIndexChanged(object sender, EventArgs e)
        {
            String conversationID = gvAllConversations.Rows[gvAllConversations.SelectedIndex].Cells[0].Text;
            
            Session["conversationID"] = conversationID;
            Response.Redirect("~/IndividualConversation.aspx");
        }

        protected void btnSeeConversation_Click(object sender, EventArgs e)
        {
            
        }
    }
}