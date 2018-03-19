using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;
using System.Collections;
using MembersLibrary;
namespace Project3
{
    public partial class DateRequestSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtParticipant1.Text = "Tim";
            txtParticipant2.Text = "Jane";
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //String requestID = Session["RequestID"].ToString();
            DateRequestClass.updateDateTimeLocation("TimJane", "February 15th", "11pm", "Times Square");
        }
    }
}