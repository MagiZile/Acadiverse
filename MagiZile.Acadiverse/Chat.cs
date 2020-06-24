using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.Acadiverse
{
    public class Chat
    {
        public event EventHandler<ChatEventArgs> ChatMessageSent;
        public event EventHandler<ChatEventArgs> ChatMessageEdited;

        public System.Windows.Forms.Timer tmrUpdateChat;
        public BackgroundWorker bgwUpdateChat;
        bool isPrivate;
        string name;
        string description;
        BsonObjectId ownerID;
        BsonObjectId chatID;
        BsonArray chatModerators;
        BsonArray blockedUsers;
        BsonArray chatMessageArray = new BsonArray();

        public bool IsPrivate { get => isPrivate; set => isPrivate = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public BsonObjectId OwnerID { get => ownerID; set => ownerID = value; }
        public BsonObjectId ChatID { get => chatID; set => chatID = value; }
        public BsonArray ChatModerators { get => chatModerators; set => chatModerators = value; }
        public BsonArray BlockedUsers { get => blockedUsers; set => blockedUsers = value; }

        public static  Chat LoadFromServer(BsonObjectId id)
        {
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat");
            var documents = collection.Find(new BsonDocument()).ToList();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var document = collection.Find(filter).FirstOrDefault();
            return LoadFromServer(document.GetElement("name").Value.AsString);
        }

        public static  Chat LoadFromServer(string name)
        {
            Chat chat = new Chat();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat");
            var documents = collection.Find(new BsonDocument()).ToList();
            var filter = Builders<BsonDocument>.Filter.Eq("name", name);
            var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {
                    return null;
                }
            chat.OwnerID = document.GetElement("owner_id").Value.AsObjectId;
            chat.Name = document.GetElement("name").Value.AsString;
            chat.Description = document.GetElement("description").Value.AsString;
            chat.IsPrivate = document.GetElement("is_private").Value.AsBoolean;
            chat.ChatModerators = document.GetElement("chat_moderators").Value.AsBsonArray;
            chat.BlockedUsers = document.GetElement("blocked_users").Value.AsBsonArray;
            chat.UpdateChatMessages();
            return chat;
        }

        public static List<Chat> GetAllChats()
        {
            List<Chat> chats = new List<Chat>();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("chat");
                var documents = collection.Find(new BsonDocument()).ToList();
                foreach (BsonDocument doc in documents)
                {
                    chats.Add(new Chat
                    {
                        ChatID = doc.GetElement("_id").Value.AsObjectId,
                        IsPrivate = doc.GetElement("is_private").Value.AsBoolean,
                        Name = doc.GetElement("name").Value.AsString,
                        Description = doc.GetElement("description").Value.AsString,
                        OwnerID = doc.GetElement("owner_id").Value.AsObjectId,
                        ChatModerators = doc.GetElement("chat_moderators").Value.AsBsonArray,
                        BlockedUsers = doc.GetElement("blocked_users").Value.AsBsonArray
                    });
                }
            return chats;
        }

        public static List<Chat> GetPublicChats()
        {
            List<Chat> publicChats = new List<Chat>();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat");
                var documents = collection.Find(new BsonDocument()).ToList();
                foreach (BsonDocument doc in documents)
                {
                if (!doc.GetElement("is_private").Value.AsBoolean)
                    {
                    publicChats.Add(new Chat
                    {
                        ChatID = doc.GetElement("_id").Value.AsObjectId,
                        IsPrivate = doc.GetElement("is_private").Value.AsBoolean,
                        Name = doc.GetElement("name").Value.AsString,
                        Description = doc.GetElement("description").Value.AsString,
                        OwnerID = doc.GetElement("owner_id").Value.AsObjectId,
                        ChatModerators = doc.GetElement("chat_moderators").Value.AsBsonArray,
                        BlockedUsers = doc.GetElement("blocked_users").Value.AsBsonArray
                    });
                }
                }
            return publicChats;
        }

        public List<Chat> GetOwnedChats(Account account)
        {
            List<Chat> ownedChats = new List<Chat>();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chats");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument doc in documents)
            {
                if(doc.GetElement("owner_id").Value.AsObjectId.Equals(account.ID))
                {
                    ownedChats.Add(LoadFromServer(doc.GetElement("_id").Value.AsObjectId));
                }
            }
            return ownedChats;
        }

        public void SaveToServer()
        {
            if (!Globals.InCollection("chat", "name", Name))
            {
                MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("chat");
                var document = new BsonDocument { { "name", Name },
                    {"description", Description },
                    {"is_private", true },
                    {"owner_id", OwnerID },
                    {"chat_moderators", new BsonArray() },
                    {"blocked_users", new BsonArray() },
                    {"chat_messages", new BsonArray() }
                };
                collection.InsertOne(document);
            }
            else
            {
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "owner_id", OwnerID);
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "name", Name);
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "description", Description);
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "is_private", IsPrivate);
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "chat_moderators", ChatModerators);
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "blocked_users", BlockedUsers);
                Globals.UpdateValue("chat", "_id", ChatID.AsString, "chat_messages", UpdateChatMessages());
            }
        }

        public void DeleteAllMessages()
        {
            chatMessageArray = UpdateChatMessages();
            for (int i = 0; i < chatMessageArray.Count; i++)
            {
                BsonObjectId id = chatMessageArray.ElementAt(i).AsObjectId;
                ChatMessage chatMessage = ChatMessage.LoadFromServer(id);
                chatMessage.DeleteMessage(true);
            }
            chatMessageArray.Clear();
            SaveToServer();
        }

        public void DeleteChat()
        {
            DeleteAllMessages();
            MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbclient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat");
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", chatID);
            collection.DeleteOne(deleteFilter);
        }

        public BsonArray UpdateChatMessages()
        {
            BsonArray chatMessages = new BsonArray();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("chat_messages");
            var filter = Builders<BsonDocument>.Filter.Eq("chat_id", ChatID);
            var documents = collection.Find(filter).ToList();
            foreach (BsonDocument document in documents)
            {
                chatMessages.Add(document.GetElement("_id").Value.AsObjectId);
                if (!chatMessageArray.Contains(document.GetElement("_id").Value.AsObjectId))
                {
                    ChatMessageSent?.Invoke(this, new ChatEventArgs(ChatMessage.LoadFromServer(document.GetElement("_id").Value.AsObjectId)));
                }
                else
                {
                    BsonArray newChatMessages = new BsonArray(ChatMessage.GetChatMessageIDs(chatID));
                    foreach (BsonObjectId messageID in chatMessages)
                    {
                        foreach (BsonObjectId id in chatMessageArray)
                        {
                            ChatMessage msg1 = ChatMessage.LoadFromServer(id);
                            ChatMessage msg2 = ChatMessage.LoadFromServer(messageID);
                            if (!msg1.Equals(msg2))
                            {
                                ChatMessageEdited?.Invoke(this, new ChatEventArgs(ChatMessage.LoadFromServer(document.GetElement("_id").Value.AsObjectId)));
                            }
                        }
                        newChatMessages.Add(messageID);
                    }
                }
            }
            if (chatMessageArray.Count > 100)
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var messageCollection = database.GetCollection<BsonDocument>("chat_messages");
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", chatMessageArray[0].AsObjectId);
                collection.DeleteOne(deleteFilter);
                chatMessageArray.Remove(chatMessageArray.ElementAt(0));
            }
            return chatMessages;
        }
    }
}

