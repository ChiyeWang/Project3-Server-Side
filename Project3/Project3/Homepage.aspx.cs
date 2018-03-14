using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3
{
    public partial class Homepage : System.Web.UI.Page
    {
        private bool userType;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "" && txtFullName.Text != "" && txtEmail.Text != "") 
            {
                //MemeberFunction.InsertMember(txtUserName.Text, txtPassword.Text, txtFullName.Text, txtEmail.Text);
                txtUserName.Text = (string)Session["Username"]; // check duplicate ***
                userType = true;                    // is a member
                userType = (bool)Session["UserType"];
                Response.Redirect("ProfilePage.aspx");
            }
            else
            {
                lblError.Text = "Please Enter all the fields";
                lblError.Visible = true;
            }
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}