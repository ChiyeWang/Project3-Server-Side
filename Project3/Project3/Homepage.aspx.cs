using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MembersLibrary;

namespace Project3
{
    public partial class Homepage : System.Web.UI.Page
    {
        private bool userType;
        DataManipulation data = new DataManipulation();
        Member member;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "" && txtFullName.Text != "" && txtEmail.Text != "") 
            {
                member = new Member(txtUserName.Text, txtPassword.Text, txtFullName.Text, txtEmail.Text);
                data.createMember(member);
                txtUserName.Text = (string)Session["Username"]; // check duplicate ***
                userType = true;                    // is a member

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