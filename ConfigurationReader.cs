using System;
using System.IO;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace contactmgr
{
    public class ConfigurationReader
    {

        public ConfigurationReader()
        {
            SetMongoServer();
        }
        public static IConfigurationRoot Configuration { get; set; }

        public string MongoServer { get; set; }
        private void SetMongoServer()
        {
            var builder = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            // Console.WriteLine($"MongoServer = {Configuration["MongoServer"]}");
            MongoServer = Configuration["MongoServer"];
            // Console.ReadLine();
        }
    }
}