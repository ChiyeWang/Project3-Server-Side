using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersLibrary
{
    public class Member
    {
        public string userName { set; get; }
        public string password { set; get; }
        public string fullName { set; get; }
        public string emailAddress { set; get; }

        //Public properties that everyone can see it
        //changed the case of the variable names for consistency! so all of them begin
        //with a lower case
        public string state { set; get; }
        public string description { set; get; }
        public string address { set; get; }
        public string contactEmail { set; get; }
        public string age { set; get; }
        public string height { set; get; }
        public string commitmentType { set; get; }
        public string likes { set; get; }
        public string profilePhoto { set; get; }

        //Private properties that only members can see
        public string phoneNumber { set; get; }
        public string occupation { set; get; }
        public string favorites { set; get; }
        public string city { set; get; }
        //Private properties that keep track of the persons request status
        //property to indicate whether or not their profile shows up
        public bool show { set; get; }

        public Member(string UserName, string Password, string FullName, string EmailAddress)
        {
            this.userName = UserName;
            this.password = Password;
            this.fullName = FullName;
            this.emailAddress = EmailAddress;
        }

        //you can simplify propertiese of a class to shorthand {set;get;}!
        //I kept the old code here
        /*
        public string UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        public string CommitmentType
        {
            get { return commitmentType; }
            set { commitmentType = value; }
        }

        public string Likes
        {
            get { return likes; }
            set { likes = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Occupation
        {
            get { return Occupation; }
            set { occupation = value; }
        }

        public string Favorites
        {
            get { return favorites; }
            set { favorites = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }*/
    }
}
