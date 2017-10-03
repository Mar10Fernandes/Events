using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace EventsRepository
{
    public class BaseRepository
    {
        public readonly IConfiguration Configuration; 

        public BaseRepository(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IMongoDatabase GetDatabase()
        {
            IMongoDatabase database = null;

            var client = new MongoClient(Configuration.GetSection("MongoConnection:ConnectionString").Value);
            if (client != null)
                database = client.GetDatabase(Configuration.GetSection("MongoConnection:Database").Value);

            return database;
        }
    }
}
