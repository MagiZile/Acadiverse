using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.Acadiverse
{
    public class UserRole
    {
        string roleName;
        BsonArray associatedUsers;

        public string RoleName { get => roleName; set => roleName = value; }
        public BsonArray AssociatedUsers { get => associatedUsers; set => associatedUsers = value; }

        public void SaveToServer()
        {
            if (Globals.InCollection("user_roles", "role_name", RoleName))
            {
                Globals.UpdateValue("user_roles", "role_name", RoleName, "associated_users", AssociatedUsers);
            }
            else
            {
                MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("user_roles");
                var document = new BsonDocument { { "role_name", RoleName },
                    {"associated_users", AssociatedUsers } };
                collection.InsertOne(document);
            }
        }

        public void RemoveFromRole(BsonObjectId id)
        {
            AssociatedUsers.Remove(id);
            SaveToServer();
        }

        public static UserRole LoadFromServer(string roleName)
        {
            UserRole userRole = new UserRole();
            MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("user_roles");
            var filter = Builders<BsonDocument>.Filter.Eq("role_name", roleName);
            var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {
                    return null;
                }
            userRole.RoleName = document.GetElement("role_name").Value.AsString;
            userRole.AssociatedUsers = document.GetElement("associated_users").Value.AsBsonArray;
            return userRole;
        }

        public static List<UserRole> GetAllUserRoles()
        {
                List<UserRole> userRoles = new List<UserRole>();
                MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("user_roles");
                var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument doc in documents)
            {
                userRoles.Add(new UserRole
                {
                    RoleName = doc.GetElement("role_name").Value.AsString,
                    AssociatedUsers = doc.GetElement("associated_users").Value.AsBsonArray
                });
            }
            return userRoles;
        }

        public static bool UserHasRole(Account account, string roleName)
        {
            return LoadFromServer(roleName).AssociatedUsers.Contains(account.ID);
        }

        public void MessageAllUsers(Account sender, string subject, string message)
        {
            List<Account> accounts = new List<Account>();
            foreach (BsonObjectId id in AssociatedUsers)
            {
                accounts.Add(Account.LoadFromServer(id));
            }
            foreach (Account account in accounts)
            {
                Account.SendPM(sender, account, subject, message);
            }
        }
    }
}
