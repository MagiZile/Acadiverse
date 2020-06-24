using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.Acadiverse
{
    /// <summary>
    /// Represents an infraction against an Acadiverse account
    /// </summary>
    public class Infraction
    {

        BsonObjectId id;
        string associatedUsername;
        InfractionType type;
        string moderatorName;
        DateTime infractionDate;
        string reason;

        public BsonObjectId Id { get => id; set => id = value; }
        public string AssociatedUsername { get => associatedUsername; set => associatedUsername = value; }
        public InfractionType Type { get => type; set => type = value; }
        public string ModeratorName { get => moderatorName; set => moderatorName = value; }
        public DateTime InfractionDate { get => infractionDate; set => infractionDate = value; }
        public string Reason { get => reason; set => reason = value; }
        

        public Infraction(string associatedUsername, InfractionType type, string moderatorName, DateTime infractionDate, string reason)
        {
            this.associatedUsername = associatedUsername;
            this.Type = type;
            this.ModeratorName = moderatorName;
            this.InfractionDate = infractionDate;
            this.Reason = reason;
        }

        public void SaveToServer()
        {
            MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbclient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("moderator_actions");
            var document = new BsonDocument { {"associated_username", AssociatedUsername },
                { "infraction_type", Type.ToString() },
                {"moderator_name", ModeratorName },
                {"infraction_date", InfractionDate },
                {"reason", Reason }
            };
            collection.InsertOne(document);
        }

        public static List<Infraction> GetAllInfractions(string associatedUsername)
        {
            MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbclient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("moderator_actions");
            var filter = Builders<BsonDocument>.Filter.Eq("associated_username", associatedUsername);
            var documents = collection.Find(filter);
            List<Infraction> infractions = new List<Infraction>();
            foreach (BsonDocument document in documents.ToList())
            {
                InfractionType infractionType = InfractionType.Warning;
                switch (document.GetElement(2).Value.AsString)
                {
                    case "Warning":
                        infractionType = InfractionType.Warning;
                        break;
                    case "ChatBan":
                        infractionType = InfractionType.ChatBan;
                        break;
                    case "PublishingBan":
                        infractionType = InfractionType.PublishingBan;
                        break;
                    case "Tempban":
                        infractionType = InfractionType.Tempban;
                        break;
                    case "Permaban":
                        infractionType = InfractionType.Permaban;
                        break;
                    case "SubmissionDeletion":
                        infractionType = InfractionType.SubmissionDeletion;
                        break;
                    case "ChatMessageDeletion":
                        infractionType = InfractionType.ChatMessageDeletion;
                        break;
                    default:
                        throw (new InvalidOperationException());
                }
                infractions.Add(new Infraction(associatedUsername, infractionType, document.GetElement(3).Value.AsString, document.GetElement(4).Value.ToUniversalTime(), document.GetElement(5).Value.AsString));
            }
            return infractions;
        }
    }
}