using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MembersLibrary;

namespace Project3
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        private string username;
        private Member user;
        private DataManipulation obj = new DataManipulation();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserType"].ToString() == "v")
                {
                    Response.Redirect("/search.aspx");
                }
                username = (string)Session["User"].ToString();
                lblWelcome.Text = "Welcome " + username + ", this is your profile page, you can modify your profile and click modify to start and click the button again to save. You also can keep your profile private by clicking on remove public profile transaction.";
                user = obj.memberPublic(username);
                display(user);
            }
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            TurnReadOnly();
            username = (string)Session["User"].ToString();
            user = new Member(username, txtState.Text.ToLower(), txtDescription.Text, txtAddress.Text, txtEmailAddress.Text, 
                              txtAge.Text, txtHeight.Text, ddlCommitmentType.Text, txtLikes.Text, txtJobType.Text, 
                              txtPhone.Text, txtCity.Text, txtOccupation.Text.ToLower(), txtFavorites.Text);
            obj.updateProfile(user);
        }

        public void display(Member member)
        {
            txtState.Text = member.state;
            txtEmailAddress.Text = member.contactEmail;
            txtLikes.Text = member.likes;
            txtAge.Text = member.age;
            txtHeight.Text = member.height;
            txtJobType.Text = member.jobType;
            ddlCommitmentType.Text = member.commitmentType;
            txtAddress.Text = member.address;
            txtDescription.Text= member.description;
            txtCity.Text = member.city;
            txtOccupation.Text = member.occupation;
            txtFavorites.Text = member.favorites;
            txtPhone.Text = member.phoneNumber;
        }

        public void TurnReadOnly()
        {
            txtState.Enabled = true;
            txtEmailAddress.Enabled = true;
            txtLikes.Enabled = true;
            txtAge.Enabled = true;
            txtHeight.Enabled = true;
            txtJobType.Enabled = true;
            txtAddress.Enabled = true;
            txtDescription.Enabled = true;
            txtPhone.Enabled = true;
            txtCity.Enabled = true;
            txtOccupation.Enabled = true;
            txtFavorites.Enabled = true;
            ddlCommitmentType.Enabled = true;
        }

    }
}