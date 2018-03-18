using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace MembersLibrary
{
    public static class CommunicationClass
    {
        public static DBConnect objDB = new DBConnect();
        public static DataSet dsConversations = objDB.GetDataSet("SELECT * FROM Conversation"); //ADD
        public static DataSet dsMessages = objDB.GetDataSet("SELECT * FROM Message"); //ADD
        public static SqlCommand objCommand = new SqlCommand();

        public static void NewConversation(String personA, String personB)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
            /*
            String command1 = "INSERT INTO Conversation (Sender, Receiver) VALUE ('" +
                personA + "','" + personB + "');";
            String command2 = "INSERT INTO Conversation (Sender, Receiver) VALUE ('" +
                personB + "','" + personA + "');";
            objDB.DoUpdate(command1);
            objDB.DoUpdate(command2);*/
        }
        private static String SearchConversation(String personA, String personB)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
            String conversationID = "";

            return conversationID;
            /*
            DataSet conversation = objDB.GetDataSet("SELECT ConversationID FROM Conversation WHERE Sender = '" +
                personA + "' AND Receiver = '" + personB+"';");
            // return conversation;
            String conversationID = "";
            conversationID = conversation.Tables[0].Rows[0][0].ToString(); // TEST
            return conversationID;*/
        }

        public static void GetMessages(String personA, String personB)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
            /*
            String conversationID = SearchConversation(personA, personB);
            String command = "SELECT Sender, Content FROM Message WHERE ConversationID = '"+conversationID+
                "' ORDER BY MessageID ASC";
            objDB.DoUpdate(command);*/
        }
        public static void InsertMessage(String personA, String conversationID, String content)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
            /*
            String command = "INSERT INTO Message (ConversationID, Sender, Content) VALUES ('" +
                conversationID + "','" + personA + "','" + content + "');";
            objDB.DoUpdate(command);*/
        }
        public static void DeleteMessage(String personA, String conversationID, String content)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = ""; //ADD
            objDB.GetDataSetUsingCmdObj(objCommand);
            /*   
            String command = "DELETE FROM Message WHERE ConversationID =" +
                conversationID + " AND Sender = '" + personA + "' AND Content = '" + content + "';"; //CHECK
            objDB.DoUpdate(command);*/
        }
    }

}
