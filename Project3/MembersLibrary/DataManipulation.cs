using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities; //need to include utilities
using System.Data;
using System.Data.SqlClient;

namespace MembersLibrary
{
    
    public class DataManipulation
    {
        //for the public static methods that will manipulate member info - such as updating database
        static DBConnect objDB = new DBConnect();
        static DataSet ds = objDB.GetDataSet("SELECT * FROM Member"); //NEED TO CHANGE TO DATABASE NAME
        SqlCommand obj = new SqlCommand();


        public DataManipulation()
        {

        }

        //parameterized constructor
        public DataManipulation(String username, String fullName, String password,
            String email, String state, String description, String profilePhoto)
        {

        }

        public void createMember(Member member)
        {
            /*
            String dbCommand = "INSERT INTO Member(Username, Password, Fullname, EmailAddress)" +
            "VALUES('" + member.userName + "','" + member.password + "','" + member.fullName + "','" +
            member.emailAddress + "');";
            int i = objDB.DoUpdate(dbCommand);
            //allow nulls for profile? or initialize to null or zero?
            */
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "CreateMember";
            SqlParameter input = new SqlParameter("@userName", member.userName);
            obj.Parameters.Add(input);
            input = new SqlParameter("@Password", member.password);
            obj.Parameters.Add(input);
            input = new SqlParameter("@FullName", member.fullName);
            obj.Parameters.Add(input);
            input = new SqlParameter("@EmailAddress", member.emailAddress);
            obj.Parameters.Add(input);
            objDB.DoUpdateUsingCmdObj(obj);
        }

        public int CheckDuplicate(string username)
        {
            int count = 0;
            String dbCommand = "Select * FROM Member WHERE Username = '" + username + "';";

            objDB.GetDataSet(dbCommand, out count);
            return count;
        }

        public string checkPassword(string username)
        {
            //String dbCommand = "Select Password FROM Member WHERE Username = '" + username + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "GetPassword";
            SqlParameter input = new SqlParameter("@Username", username);
            obj.Parameters.Add(input);
            ds = objDB.GetDataSetUsingCmdObj(obj);
            string password = ds.Tables[0].Rows[0][0].ToString();
            return password;
        }
        
        public Member memberPublic(string username)
        {

            //String dbCommand = "SELECT State,Description,Address,ContactEmail,Age,Height,CommitmentType,Likes,JobType,PhoneNumber,City,Occupation,Favorites FROM Member WhERE Username = '" + username + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "GetProfile";
            SqlParameter input = new SqlParameter("@Username", username);
            obj.Parameters.Add(input);
            DataTable dt = objDB.GetDataSetUsingCmdObj(obj).Tables[0];
            Member user = new Member(username, dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(),
                                    dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString());
            return user;
            
        }

        
        public void updateProfile(Member member)
        {
            /*
            String dbCommand = "UPDATE Member SET City='" + member.city + "',State='"+member.state+ "',Description='" + member.description+ "',Address='" + member.address
                + "',ContactEmail='" + member.contactEmail+ "',Age='" + member.age+ "',Height='" + member.height+ "',CommitmentType='" + member.commitmentType+ "',Likes='" + member.likes+
                "',JobType='" + member.jobType+ "',PhoneNumber='" + member.phoneNumber+ "'" +
                ",Occupation='" + member.occupation+ "',Favorites='" + member.favorites+ "' WHERE Username='"+member.userName+"';";
           */
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "UpdateProfile";
            SqlParameter input = new SqlParameter("city", member.city);
            obj.Parameters.Add(input);
            input = new SqlParameter("state", member.state);
            obj.Parameters.Add(input);
            input = new SqlParameter("description", member.description);
            obj.Parameters.Add(input);
            input = new SqlParameter("address", member.address);
            obj.Parameters.Add(input);
            input = new SqlParameter("contactEmail", member.contactEmail);
            obj.Parameters.Add(input);
            input = new SqlParameter("age", member.age);
            obj.Parameters.Add(input);
            input = new SqlParameter("height", member.height);
            obj.Parameters.Add(input);
            input = new SqlParameter("commitmentType", member.commitmentType);
            obj.Parameters.Add(input);
            input = new SqlParameter("likes", member.likes);
            obj.Parameters.Add(input);
            input = new SqlParameter("jobType", member.jobType);
            obj.Parameters.Add(input);
            input = new SqlParameter("phoneNumber", member.phoneNumber);
            obj.Parameters.Add(input);
            input = new SqlParameter("occupation", member.occupation);
            obj.Parameters.Add(input);
            input = new SqlParameter("favorites", member.favorites);
            obj.Parameters.Add(input);
            input = new SqlParameter("@Username", member.userName);
            obj.Parameters.Add(input);
            objDB.DoUpdateUsingCmdObj(obj);

        }

        public DataSet GuestSearchState(string state)
        {
            state = state.Trim();
            state = state.ToLower();

            //string sql = "SELECT Fullname, State, CommitmentType, Likes, Description FROM Member WHERE State = '" + state + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "GuestSearchByState";
            SqlParameter input = new SqlParameter("state", state);
            obj.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(obj);
            return ds;
        }

        public DataSet PublicSearchState(string state)
        {
            state = state.Trim();
            state = state.ToLower();

            //string sql = "SELECT Fullname, State, Occupation, Age, CommitmentType, Height, Description FROM Member WHERE State = '" + state + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "PublicSearchByState";
            SqlParameter input = new SqlParameter("state", state);
            obj.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(obj);
            return ds;
        }

        public DataSet GuestSearchCommitment(string ct)
        {
            //string sql = "SELECT Fullname, State, CommitmentType, Likes, Description FROM Member WHERE CommitmentType = '" + obj + "';";

            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "GuestSearchByCommitment";
            SqlParameter input = new SqlParameter("commitmentType", ct);
            obj.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(obj);
            return ds;
        }

        public DataSet PublicSearchCommitment(string ct)
        {

            //string sql = "SELECT Fullname, State, Occupation, Age, CommitmentType, Height, Description FROM Member WHERE CommitmentType = '" + obj + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "PublicSearchByCommitment";
            SqlParameter input = new SqlParameter("commitmentType", ct);
            obj.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(obj);
            return ds;
        }
        
        public DataSet PublicSearchAge(string age)
        {
            //string sql = "SELECT Fullname, State, Occupation, Age, CommitmentType, Height, Description FROM Member WHERE Age = '" + obj + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "PublicSearchByAge";
            SqlParameter input = new SqlParameter("age", age);
            obj.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(obj);
            return ds;
        }

        public DataSet PublicSearchOccupation(string occu)
        {
            //string sql = "SELECT Fullname, State, Occupation, Age, CommitmentType, Height, Description FROM Member WHERE Occupation = '" + obj + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "PublicSearchByOccupation";
            SqlParameter input = new SqlParameter("occupation", occu);
            obj.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(obj);
            return ds;
        }

        public Member GetProfile(string name)
        {
            //string sql = "SELECT Fullname, State, Occupation, Age, CommitmentType, Height, Likes, JobType, Description, ContactEmail FROM Member WHERE Fullname = '" + name + "';";
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "GetProfileForResult";
            SqlParameter input = new SqlParameter("fullname", name);
            obj.Parameters.Add(input);

            DataTable dt = objDB.GetDataSetUsingCmdObj(obj).Tables[0];
            Member user = new Member(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(),
                                    dt.Rows[0][3].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][2].ToString());
            return user;
        }

    }


}
