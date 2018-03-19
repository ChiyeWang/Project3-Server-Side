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
        private string userType;
        private int duplicate;
        DataManipulation data = new DataManipulation();
        Member member;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            duplicate = data.CheckDuplicate(txtUserName.Text);
            if (txtUserName.Text != "" && txtPassword.Text != "" && txtFullName.Text != "" && txtEmail.Text != "") 
            {
                if(duplicate == 0)
                {
                    member = new Member(txtUserName.Text, txtPassword.Text, txtFullName.Text, txtEmail.Text);
                    data.createMember(member);
                    Session["User"] = txtUserName.Text;
                    userType = "m";                    // is a member
                    Session["UserType"] = userType;
                    Response.Redirect("ProfilePage.aspx");
                }
                else
                {
                    lblError.Text = "The username already existed.";
                    lblError.Visible = true;  
                }
            }
            else
            {
                lblError.Text = "Please Enter all the fields";
                lblError.Visible = true;
            }
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblFullName.Visible = false;
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            txtFullName.Visible = false;
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                lblError.Text = "Enter your Username and Password";
                lblError.Visible = true;
            }else
            {
                if (txtPassword.Text == data.checkPassword(txtUserName.Text))
                {
                    Session["User"] = txtUserName.Text;
                    userType = "m";                    // is a member
                    Session["UserType"] = userType;
                    Response.Redirect("ProfilePage.aspx");
                }
                else
                {
                    lblError.Text = "Please enter the correct password";
                    lblError.Visible = true;
                }
            }
        }

        protected void btnGuest_Click(object sender, EventArgs e)
        {
            userType = "v";
            Session["UserType"] = userType;
            Response.Redirect("search.aspx");
        }
    }
}