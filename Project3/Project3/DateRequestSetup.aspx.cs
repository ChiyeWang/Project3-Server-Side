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
        String date;
        String time;
        String location;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                requestID = (String)Session["RequestID"];
                requestID = "3";
                //DateRequestClass.
                gvParticipants.DataSource = DateRequestClass.dateDetails(Convert.ToInt32(requestID));
                gvParticipants.DataBind();

            }
            else
            {
                requestID = (String)Session["RequestID"];
                requestID = "3";
                //DateRequestClass.
                gvParticipants.DataSource = DateRequestClass.dateDetails(Convert.ToInt32(requestID));
                gvParticipants.DataBind();
            }




        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //String requestID = Session["RequestID"].ToString();
            date = txtDate.Text.ToString();
            time = txtTime.Text.ToString();
            location = txtLocation.Text.ToString();
            DateRequestClass.updateDateTimeLocation(Convert.ToInt32(requestID) , date, time, location);
            gvParticipants.DataSource = DateRequestClass.dateDetails(Convert.ToInt32(requestID));
            gvParticipants.DataBind();
        }

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {
            txtDate.Text = txtDate.Text;
        }

        protected void gvParticipants_Load(object sender, EventArgs e)
        {
            if (gvParticipants.Rows[0].Cells[2].Text != null) { txtDate.Text = gvParticipants.Rows[0].Cells[2].Text; }
            
            
            if (gvParticipants.Rows[0].Cells[3].Text != null) { txtTime.Text = gvParticipants.Rows[0].Cells[3].Text; }
            //else { txtDate.Text = " "; }
            if (gvParticipants.Rows[0].Cells[4].Text != null) { txtLocation.Text = gvParticipants.Rows[0].Cells[4].Text; }
            //else { txtDate.Text = " "; }
        }
    }
}