using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MembersLibrary;
using Utilities;

namespace Project3
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        DataManipulation obj = new DataManipulation();
        Member member;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string usertype = (string)Session["UserType"].ToString();
                string name = (string)Session["name"].ToString();
                if (usertype == "v")
                {
                    member = obj.GetProfile(name);
                    display(member);
                }
                else if (usertype == "m")
                {
                    member = obj.GetProfile(name);
                    display(member);
                }
                lblProfile.Text = name + "'s Profile";
            }
        }

        public void display(Member member)
        {
            lblStateOutput.Text = member.state;
            lblContactEmailOutput.Text = member.emailAddress;
            lblLikesOutput.Text = member.likes;
            lblAgeOutput.Text = member.age;
            lblHeightOutput.Text = member.height;
            lblJobTypeOutput.Text = member.jobType;
            lblCommitmentTypeOutput.Text = member.commitmentType;
            lblDescriptionOutput.Text = member.description;
            lblNameOutput.Text = member.fullName;
            lblOccupationOutput.Text = member.occupation;
        }
    }
}