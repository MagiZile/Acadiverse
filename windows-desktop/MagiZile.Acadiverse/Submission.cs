using MagiZile.Acadiverse;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Documents;

namespace MagiZile.Acadiverse
{
    public class Submission
    {
        BsonObjectId id;
        string name;
        string description;
        Account author;
        DateTime datePublished;
        DateTime lastUpdated;
        int numberOfVotes;
        BsonArray comments;
        string submissionContents;
        BsonArray tags;
        SubmissionType type;
        int price;
        bool isStoreItem;

        public Submission(string name)
        {
            this.Id = null;
            this.Name = name;
            this.Description = "";
            this.Author = null;
            this.DatePublished = DateTime.Now;
            this.LastUpdated = DateTime.Now;
            this.NumberOfVotes = 0;
            this.Comments = new BsonArray();
            this.Tags = new BsonArray();
            type = SubmissionType.Scenario;
            price = 0;
            IsStoreItem = false;
        }

        public BsonObjectId Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Account Author { get => author; set => author = value; }
        public DateTime DatePublished { get => datePublished; set => datePublished = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }
        public int NumberOfVotes { get => numberOfVotes; set => numberOfVotes = value; }
        public BsonArray Comments { get => comments; set => comments = value; }
        public string SubmissionContents { get => submissionContents; set => submissionContents = value; }
        public BsonArray Tags { get => tags; set => tags = value; }
        public SubmissionType Type { get => Type1; set => Type1 = value; }
        public SubmissionType Type1 { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public bool IsStoreItem { get => isStoreItem; set => isStoreItem = value; }

        public void SaveToServer()
        {
            if (Globals.InCollection("submissions", "_id", Id.AsString))
            {
                Globals.UpdateValue("submissions", "_id", Id.AsString, "name", Name);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "description", Description);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "author", Author.Username);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "date_published", DatePublished);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "last_updated", LastUpdated);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "number_of_votes", NumberOfVotes);
                Globals.UpdateValue("submission", "__id", Id.AsString, "comments", Comments);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "submission_contents", SubmissionContents);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "tags", tags);
                Globals.UpdateValue("submissions", "_id", Id.AsString, "type", type.ToString());
                Globals.UpdateValue("submissions", "_id", Id.AsString, "is_store_item", isStoreItem);
            }
            else
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("submissions");
                var filter = Builders<BsonDocument>.Filter.Eq("id", Id);
                var document = new BsonDocument { { "name", Name },
                    {"description", Description },
                    {"author", Author.Username },
                    {"date_published", DateTime.Now },
                    {"last_updated", DateTime.Now },
                    {"number_of_votes", NumberOfVotes },
                    {"comments", Comments },
                    {"submission_contents", SubmissionContents },
                    {"tags", Tags },
                    {"type", Type },
                    {"price", Price },
                    {"is_store_item", IsStoreItem }
                };
            }
        }
        
        public static Submission LoadFromServer(BsonObjectId id)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("submissions");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var document = collection.Find(filter).FirstOrDefault();
                SubmissionType submissionType;
                switch (document.GetElement("type").Value.AsString)
                {
                    case "Hat":
                        submissionType = SubmissionType.Hat;
                        break;
                    case "Eyewear":
                        submissionType = SubmissionType.Eyewear;
                        break;
                    case "Top":
                        submissionType = SubmissionType.Top;
                        break;
                    case "Bottom":
                        submissionType = SubmissionType.Bottom;
                        break;
                    case "Footwear":
                        submissionType = SubmissionType.Footwear;
                        break;
                    case "Decoration":
                        submissionType = SubmissionType.Decoration;
                        break;
                    case "Worksheet":
                        submissionType = SubmissionType.Worksheet;
                        break;
                    case "Scenario":
                        submissionType = SubmissionType.Scenario;
                        break;
                    case "Quiz":
                        submissionType = SubmissionType.Quiz;
                        break;
                    default:
                        throw (new InvalidOperationException());
                }
                return new Submission(document.GetElement("name").Value.AsString)
                {
                    Description = document.GetElement("description").Value.AsString,
                    Author = Account.LoadFromServer(document.GetElement("author").Value.AsString),
                    DatePublished = document.GetElement("date_published").Value.ToUniversalTime(),
                    LastUpdated = document.GetElement("last_updated").Value.ToUniversalTime(),
                    NumberOfVotes = document.GetElement("number_of_votes").Value.AsInt32,
                    Comments = document.GetElement("comments").Value.AsBsonArray,
                    SubmissionContents = document.GetElement("submission_contents_").Value.AsString,
                    Tags = document.GetElement("tags").Value.AsBsonArray,
                    Type = submissionType,
                    Price = document.GetElement("price").Value.AsInt32,
                    IsStoreItem = document.GetElement("is_store_item").Value.AsBoolean,
                };
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
            return null;
        }
    }
}