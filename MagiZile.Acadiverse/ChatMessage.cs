using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace MagiZile.Acadiverse
{
    public class ChatMessage
    {

        BsonObjectId id;
        BsonObjectId chatID;
        string senderUsername;
        string messageContents;
        DateTime dateSent;
        
        public BsonObjectId Id { get => id; set => id = value; }
        public BsonObjectId ChatID { get => chatID; set => chatID = value; }
        public string SenderUsername { get => senderUsername; set => senderUsername = value; }
        public string MessageContents { get => messageContents; set => messageContents = value; }
        public DateTime DateSent { get => dateSent; set => dateSent = value; }
        
        

        public void SaveToServer()
        {
            if (Globals.InCollection("chat_messages", "_id", Id.AsString))
            {
                MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("chat_messages");
                var document = new BsonDocument{ { "chat_id", ChatID },
                    { "sender", senderUsername },
                {"message_contents", MessageContents },
                {"date_sent", DateSent } };
            }
            else
            {
                Globals.UpdateValue("chat_messages", "_id", Id.AsString, "sender", SenderUsername);
                Globals.UpdateValue("chat_messages", "_id", Id.AsString, "message_contents", MessageContents);
                Globals.UpdateValue("chat_messages", "_id", Id.AsString, "date_sent", DateSent);
            }
        }

        public static ChatMessage LoadFromServer(BsonObjectId id)
        {
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat_messages");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var document = collection.Find(filter).ToList()[0];
        ChatMessage objChatMessage = new ChatMessage
        {
            Id = document.GetElement(0).Value.AsObjectId,
            SenderUsername = document.GetElement("sender").Value.AsString,
                MessageContents = document.GetElement("message_contents").Value.AsString,
                DateSent = document.GetElement("date_sent").Value.ToUniversalTime()
            };
            return objChatMessage;
        }

        public static List<BsonObjectId> GetChatMessageIDs(string username)
        {
            List<BsonObjectId> ids = new List<BsonObjectId>();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat_messages");
            var filter = Builders<BsonDocument>.Filter.Eq("sender", username);
            var documents = collection.Find(filter).ToList();
            foreach (BsonDocument document in documents)
            {
                ids.Add(document.GetElement(0).Value.AsObjectId); 
            }
            return ids;
        }

        public static List<BsonObjectId> GetChatMessageIDs(BsonObjectId chatID)
        {
            List<BsonObjectId> ids = new List<BsonObjectId>();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat_messages");
            var filter = Builders<BsonDocument>.Filter.Eq("chat_id", chatID);
            var documents = collection.Find(filter).ToList();
            foreach (BsonDocument document in documents)
            {
                ids.Add(document.GetElement(0).Value.AsObjectId); 
            }
            return ids;
        }

        /// <summary>
        /// Replaces the ChatMessage with a "message removed" placeholder and makes the message "null" on the server.
        /// </summary>
        /// <param name="deletedByModerator"></param>
        public void DeleteMessage(bool deletedByModerator)
        {
            senderUsername = "";
            DateSent = new DateTime(0);
            if (deletedByModerator)
            {
                MessageContents = Properties.Resources.str_message_deleted_by_moderator;
            }
            else
            {
                MessageContents = Properties.Resources.str_message_deleted_by_user;
            }
            SaveToServer();
        }
    }
}
