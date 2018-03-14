using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities; //need to include utilities
using System.Data;

namespace MembersLibrary
{
    
    class DataManipulation
    {
        //for the public static methods that will manipulate member info - such as updating database
        static DBConnect objDB = new DBConnect();
        static DataSet ds = objDB.GetDataSet("SELECT * FROM Member"); //NEED TO CHANGE TO DATABASE NAME
        DataTable pizzaTable = ds.Tables[0];

        public DataManipulation()
        {

        }

        //parameterized constructor
        public DataManipulation(String username, String fullName, String password,
            String email, String state, String description, String profilePhoto)
        {

        }

        public static void createMember(Member member)
        {

            String dbCommand = "INSERT INTO Members(Username, Password, FullName, EmailAddress" +
            "VALUES('" + member.userName + "','" + member.password + "','" + member.fullName + "','" +
            member.emailAddress + "');";
            objDB.DoUpdate(dbCommand);
            
            //allow nulls for profile? or initialize to null or zero?

        }

        public static void updateProfile(Member member)
        {

            String dbCommand = "UPDATE Member SET City='" + member.city + "',State='"+member.state+ "',Description='" + member.description+ "',Address='" + member.address
                + "',ContactEmail='" + member.contactEmail+ "',Age='" + member.age+ "',Height='" + member.height+ "',CommitmentType='" + member.commitmentType+ "',Likes='" + member.likes+
                "',ProfilePhoto='" + member.profilePhoto+ "',PhoneNumber='" + member.phoneNumber+ "'" +
                ",Occupation='" + member.occupation+ "',Favorites='" + member.favorites+ "' WHERE Username='"+member.userName+"';";
            objDB.DoUpdate(dbCommand);

        }


    }


}
