namespace Events.Repository.MongoDB.Base.Connection
{
    public interface IConfig
    {
        string MongoConnectionString { get; }
        string MongoDatabase { get; }
    }
}
