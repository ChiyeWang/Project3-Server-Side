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

        public static void newConversation(String sender, String receiver)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "NewConversation"; //ADD
            objCommand.Parameters.AddWithValue("ConversationID", "sender"+"receiver");
            objCommand.Parameters.AddWithValue("user1", sender);
            objCommand.Parameters.AddWithValue("user2", receiver);
            objDB.GetDataSetUsingCmdObj(objCommand);
        }
        public static DataSet searchConversation(String sender, String receiver)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchForConversation"; //ADD
            objCommand.Parameters.AddWithValue("Sender", sender);
            objCommand.Parameters.AddWithValue("Receiver", receiver);
            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static DataSet myConversation(String sender)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllConversations"; //ADD
            objCommand.Parameters.AddWithValue("theUsername", sender);
            
            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static DataSet getMessages(String conversationID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllMessages"; //ADD
            objCommand.Parameters.AddWithValue("theConversationID", conversationID);
            
            return objDB.GetDataSetUsingCmdObj(objCommand);
        }
        public static void insertMessage(String conversationID, String user,String content)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "InsertMessage"; //ADD
            objCommand.Parameters.AddWithValue("conversationID", conversationID);
            objCommand.Parameters.AddWithValue("sender", user);
            objCommand.Parameters.AddWithValue("content", content);
            objDB.GetDataSetUsingCmdObj(objCommand);
        }

        public static void deleteMessage(int messageID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteMessage"; //ADD
            objCommand.Parameters.AddWithValue("MessageID", messageID);
            
            objDB.GetDataSetUsingCmdObj(objCommand);
        }
    }

}
