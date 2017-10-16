using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace contactmgr
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Contact contact = new Contact();


            var md = new MongoClient("mongodb://localhost:27017");

            var db = md.GetDatabase("testDB");

            var doc = new BsonDocument{
                {"name", "Sunny"},
                {"age", 39},
                {"phone", "9686569319"}
            };

            var coll = db.GetCollection<BsonDocument>("Contact");

            coll.InsertOne(doc);

            Console.WriteLine(contact.GetContactById("manoj mohan"));

        }
    }
}
