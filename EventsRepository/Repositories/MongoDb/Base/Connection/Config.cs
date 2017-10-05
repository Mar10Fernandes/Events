using Microsoft.Extensions.Configuration;

namespace Events.Repository.MongoDB.Base.Connection
{
    public class Config : IConfig
    {           
        public Config(IConfiguration configuration)
        {
            IConfigurationSection section = configuration.GetSection("MongoConnection"); 
            MongoConnectionString = section["ConnectionString"];
            MongoDatabase = section["Database"];            
        }
        public Config(string connectionString, string database)
        {
            MongoConnectionString = connectionString;
            MongoDatabase = database;
        }                                          
        public string MongoConnectionString { get; private set; }
        public string MongoDatabase { get; private set; }
    }
}
