using MongoDB.Bson;
using System;

namespace MagiZile.Acadiverse
{
    public class AccountDeletedEventArgs : AccountEventArgs
    {
        private MongoDB.Bson.BsonObjectId id;

        public AccountDeletedEventArgs(Account data, MongoDB.Bson.BsonObjectId id) : base(data)
        {
            this.Id = id;
        }

        public BsonObjectId Id { get => id; set => id = value; }
    }
}