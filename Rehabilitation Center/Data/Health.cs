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
    }
}
