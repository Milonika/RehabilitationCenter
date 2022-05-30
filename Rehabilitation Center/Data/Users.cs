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
    public class Users
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
        public string Pasport { get; set; }
        [BsonElement]
        public string Polis { get; set; }
        [BsonElement]
        public string Snils { get; set; }
        [BsonElement]
        public string Phone { get; set; }

        [BsonElement]
        public byte[] Photo { get; set; }

        [BsonElement]
        public int Age { get; set; }

        [BsonElement]
        public string Login { get; set; }
        [BsonElement]
        public string Password { get; set; }

        [BsonElement]
        public string Work { get; set; }
        [BsonElement]
        public string Addres { get; set; }

        [BsonElement]
        public bool IsAdmin { get; set; }

        public Users(string firstname, string name, string lastname, string pasport, string polis, string snils, string phone, int age, string login, string password, byte[] photo, string work, string addres, bool isadmin = false)
        {
            FirstName = firstname;
            Name = name;
            LastName = lastname;
            Pasport = pasport;
            Polis = polis;
            Snils = snils;
            Phone = phone;
            Age = age;
            Login = login;
            Password = password;
            Work = work;
            Addres = addres;
            IsAdmin = isadmin;
            Photo = photo;
        }

        public Users(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public async static void AddUser(Users user)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var collection = db.GetCollection<Users>("users");
            await collection.InsertOneAsync(user);
        }
        public static bool LogInUser(Users user)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var collection = db.GetCollection<Users>("users");
            var users = collection.Find(x => true).ToList();
            App.users = users.Where(x => x.Login == user.Login && x.Password == user.Password).FirstOrDefault();
            if (App.users == null)
                return false;
            return true;
        }

        public void Update()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var collection = db.GetCollection<Users>("users");
            var UpdateDef = Builders<Users>.Update.Set("Photo", App.users.Photo);
            collection.UpdateOne(basa => basa.Id == App.users.Id, UpdateDef);
        }

        public static void EditProfile()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var data = db.GetCollection<Users>("users");
            var UpdateDef = Builders<Users>.Update.Set("Polis", App.users.Polis).Set("Addres", App.users.Addres).Set("Snils", App.users.Snils).Set("Phone", App.users.Phone).Set("Pasport", App.users.Pasport).Set("Work", App.users.Work).Set("FirstName", App.users.FirstName).Set("Name", App.users.Name).Set("LastName", App.users.LastName).Set("Age", App.users.Age);
            data.UpdateOne(basa => basa.Id == App.users.Id, UpdateDef);

        }
        public async static Task<List<Users>> GetUsersTask()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var data = db.GetCollection<Users>("users");
            return data.Find(x => x.IsAdmin == false).ToList();
        }

        public async static Task<List<Users>> GetDoctorTask()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ReabilitionCenter");
            var data = db.GetCollection<Users>("users");
            return data.Find(x => x.IsAdmin == true).ToList();
        }
    }
}
