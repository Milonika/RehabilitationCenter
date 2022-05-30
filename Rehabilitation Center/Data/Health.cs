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
    class Health
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonElement]
        public int Height { get; set; }

        [BsonElement]
        public int Weight { get; set; }
        [BsonElement]
        public string Pressure { get; set; }
        [BsonElement]
        public string Saturation { get; set; }
        [BsonElement]
        public string BloodType { get; set; }
        [BsonElement]
        public string LoginUser{ get; set; }

        public Health(int height, int weight, string pressure, string saturation, string bloodType, string loginuser )
        {
            Height = height;
            Weight = weight;
            Pressure = pressure;
            Saturation = saturation;
            BloodType = bloodType;
        }
        public async static void AddHealth(Health health)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var collection = db.GetCollection<Health>("health");
            await collection.InsertOneAsync(health);
        }
    }



}
