﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
namespace Project3
{
    public partial class AllConversations : System.Web.UI.Page
    {
        static DBConnect objDB = new DBConnect();
        DataSet ds = objDB.GetDataSet("SELECT * FROM Conversation");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}