using System;
using System.IO;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace contactmgr
{

    public class Contact
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // public string Address{get; set;}

        public string GetContactById(string pContactName)
        {
            return pContactName;
            // return FirstName + ' ' + LastName;
        }

        public string Save(Contact objContact)
        {

            ConfigurationReader cr = new ConfigurationReader();

            Contact contact = new Contact();

            try
            {
                var md = new MongoClient(cr.MongoServer);

                var db = md.GetDatabase("testDB");

                var doc = new BsonDocument{
                {"name", objContact.FirstName + ' ' + objContact.LastName},
                {"phone", objContact.Phone},
                {"email", objContact.Email}
            };

                var coll = db.GetCollection<BsonDocument>("Contact");

                coll.InsertOne(doc);

                return "Contact saved successfully!";
            }
            finally
            {
                cr = null;
                contact = null;
            }
        }
    }
}
