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
        string tags;
        string[] tagsList;

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
        public string Tags { get => tags; set => tags = value; }
        public string[] TagsList { get => tags.Split(' '); }

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
                    {"tags", Tags }
                };
            }
        }
    }
}