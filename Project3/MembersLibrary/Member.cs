using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersLibrary
{
    public class Member
    {
        public string userName;
        private string password;
        private string fullName; //
        private string emailAddress;

        //Public properties that everyone can see it
        public string city;
        public string state;
        public string description;
        public string profilePhoto;

        //Private properties that only members can see
        private string phoneNumber;
        private string interests;
        private string favorites;

        //Private properties that keep track of the persons request status
        private bool request;

        public Member(string UserName, string Password, string FullName, string EmailAddress)
        {
            this.userName = UserName;
            this.password = Password;
            this.fullName = FullName;
            this.emailAddress = EmailAddress;
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

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Interests
        {
            get { return interests; }
            set { interests = value; }
        }

        public string Favorites
        {
            get { return favorites; }
            set { favorites = value; }
        }

        public bool Request
        {
            get { return request; }
            set { request = value; }
        }
    }
}
