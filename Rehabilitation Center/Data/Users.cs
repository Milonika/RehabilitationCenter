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
    class Users
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }

        [BsonElement]
        public string FirstName { get; set; }

        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string LastName { get; set; }
        [BsonElement]
        public string Pasport{ get; set; }
        [BsonElement]
        public string Polis { get; set; }
        [BsonElement]
        public string Snils { get; set; }
        [BsonElement]
        public string Phone { get; set; }
        [BsonElement]
        public string Photo { get; set; }
        [BsonElement]
        public string Age { get; set; }

        [BsonElement]
        public bool IsAdmin { get; set; }
    }
}
