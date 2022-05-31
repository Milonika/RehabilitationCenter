﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehabilitation_Center.Data
{
    public class Health
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
        public string Davleine { get; set; }
        [BsonElement]
        public string BloodType { get; set; }
        [BsonElement]
        public string Dependece{ get; set; }

        public Health(int height, int weight, string pressure, string saturation, string davleine, string bloodType, string dependece)
        {
            Height = height;
            Weight = weight;
            Pressure = pressure;
            Saturation = saturation;
            Davleine = davleine;
            BloodType = bloodType;
            Dependece = dependece;
        }

        public Health()
        {
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
