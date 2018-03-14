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
        static DataSet ds = objDB.GetDataSet("SELECT * FROM Pizza"); //NEED TO CHANGE TO DATABASE NAME
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
            "VALUES('" + member.UserName+"','"+member.Password+"','"+member.FullName + "','" +
            member.EmailAddress + "');" +
                objDB.DoUpdate(dbCommand);
            
            //allow nulls for profile? or initialize to null or zero?

        }

        public static void updateProfile(Member member)
        {

            String dbCommand = "UPDATE Member SET  +
            "VALUES('" + member.UserName + "','" + member.Password + "','" + member.FullName + "','" +
            member.EmailAddress + "');" +
                objDB.DoUpdate(dbCommand);


        }


    }


}
