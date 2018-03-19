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
        String requestID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                 requestID = Session["RequestID"].ToString();
                //DateRequestClass.
                gvParticipants.DataSource = DateRequestClass.dateDetails(Convert.ToInt32(requestID));
                gvParticipants.DataBind();
            }
            
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //String requestID = Session["RequestID"].ToString();
            DateRequestClass.updateDateTimeLocation(requestID , txtDate.Text, txtTime.Text, txtLocation.Text);

        }
    }
}