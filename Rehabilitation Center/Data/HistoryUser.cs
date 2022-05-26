using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehabilitation_Center.Data
{
    public class HistoryUser
    {

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Price { get; set; }

        public HistoryUser(string name, string price)
        {
            Name = name;
            Price = price;
        }
        public async static void AddHistoryUser(HistoryUser historyUser)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var collection = db.GetCollection<HistoryUser>("historyuser");
            await collection.InsertOneAsync(historyUser);
        }
    }
}
