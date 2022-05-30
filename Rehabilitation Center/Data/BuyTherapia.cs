using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehabilitation_Center.Data
{
    class BuyTherapia
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonElement]
        public Therapy Therapy { get; set; }
        [BsonElement]
        public Users User { get; set; }
        public static Action OnAdd;


        public async void Add()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var coll = db.GetCollection<BuyTherapia>("BuyTherapia");
            await coll.InsertOneAsync(this);
            OnAdd?.Invoke();
        }

        public static async Task<List<BuyTherapia>> Take()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            return await db.GetCollection<BuyTherapia>("BuyTherapia").FindAsync(x => true).Result.ToListAsync();
        }
    }
}
