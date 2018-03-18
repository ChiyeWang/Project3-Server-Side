using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
namespace MembersLibrary
{
    class CommunicationClass
    {
        static DBConnect objDB = new DBConnect();
        DataSet dsConversations = objDB.GetDataSet("SELECT * FROM Conversation"); //ADD
        DataSet dsMessages = objDB.GetDataSet("SELECT * FROM Message"); //ADD

        
        public static void NewConversation(Member personA, Member personB)
        {
            String command1 = "INSERT INTO Conversation (Sender, Receiver) VALUE ('" +
                personA.userName + "','" + personB.userName + "');";
            String command2 = "INSERT INTO Conversation (Sender, Receiver) VALUE ('" +
                personB.userName + "','" + personA.userName + "');";
            objDB.DoUpdate(command1);
            objDB.DoUpdate(command2);
        }
        private static String SearchConversation(Member personA, Member personB)
        {
            DataSet conversation = objDB.GetDataSet("SELECT ConversationID FROM Conversation WHERE Sender = '" +
                personA.userName + "' AND Receiver = '" + personB.userName+"';");
            // return conversation;
            String conversationID = "";
            conversationID = conversation.Tables[0].Rows[0][0].ToString(); // TEST
            return conversationID;
        }

        public static void GetMessages(Member personA, Member personB)
        {
            String conversationID = SearchConversation(personA, personB);
            String command = "SELECT Sender, Content FROM Message WHERE ConversationID = '"+conversationID+
                "' ORDER BY MessageID ASC";
            objDB.DoUpdate(command);
        }
        public static void InsertMessage(Member personA, Member personB, String content)
        {
            String conversationID = SearchConversation(personA, personB);
            String command = "INSERT INTO Message (ConversationID, Sender, Content) VALUES ('" +
                conversationID + "','" + personA.userName + "','" + content + "');";
            objDB.DoUpdate(command);
        }
        public static void DeleteMessage(Member personA, Member personB, String content)
        {
            String conversationID = SearchConversation(personA, personB);
            String command = "DELETE FROM Message WHERE ConversationID ='" +
                conversationID + "' AND Sender = '" + personA.userName + "' AND Content = '" + content + "';"; //CHECK
            objDB.DoUpdate(command);
        }
    }

}
