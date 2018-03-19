using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MembersLibrary;

namespace Project3
{
    public partial class search : System.Web.UI.Page
    {
        DataManipulation obj = new DataManipulation();
        private string userType;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userType = (string)Session["UserType"].ToString();
                if (userType == "v")
                {
                    txtSearchAge.Enabled = false;
                    txtSearchOccupation.Enabled = false;
                    btnSearchAge.Enabled = false;
                    btnSearchOccupation.Enabled = false;
                }
            }
        }

        protected void btnSearchState_Click(object sender, EventArgs e)
        {
            userType = (string)Session["UserType"].ToString();
            lblInstruction.Text = userType;
            if (userType == "v")
            {
                gvGuestResult.DataSource = obj.GuestSearchState(txtSearchState.Text);
                gvGuestResult.DataBind();
                gvGuestResult.Visible = true;
            }else if (userType == "m")
            {
                gvPublicResult.DataSource = obj.PublicSearchState(txtSearchState.Text);
                gvPublicResult.DataBind();
                gvPublicResult.Visible = true;
            }
        }

        protected void btnSearchCommitment_Click(object sender, EventArgs e)
        {
            userType = (string)Session["UserType"].ToString();
            if (userType == "v")
            {
                gvGuestResult.DataSource = obj.GuestSearchCommitment(txtSearchCommitment.Text);
                gvGuestResult.DataBind();
                gvGuestResult.Visible = true;
            }
            else if (userType == "m")
            {
                gvPublicResult.DataSource = obj.PublicSearchCommitment(txtSearchCommitment.Text);
                gvPublicResult.DataBind();
                gvPublicResult.Visible = true;
            }
        }

        protected void btnSearchAge_Click(object sender, EventArgs e)
        {
            gvPublicResult.DataSource = obj.PublicSearchAge(txtSearchAge.Text);
            gvPublicResult.DataBind();
            gvPublicResult.Visible = true;
        }

        protected void btnSearchOccupation_Click(object sender, EventArgs e)
        {
            gvPublicResult.DataSource = obj.PublicSearchOccupation(txtSearchOccupation.Text);
            gvPublicResult.DataBind();
            gvPublicResult.Visible = true;
        }


        protected void gvGuestResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = gvGuestResult.SelectedRow.Cells[0].Text;
            Session["name"] = name;
            Response.Redirect("ViewProfile.aspx");
        }

        protected void gvPublicResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = gvPublicResult.SelectedRow.Cells[0].Text;
            Session["name"] = name;
            Response.Redirect("ViewProfile.aspx");
        }
    }
}