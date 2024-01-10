using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DataAccess;

public class MongodbContext
{
    private readonly IMongoDatabase _database;

    public MongodbContext(IOptions<DatabaseSettings> databaseSettings)
    {
        var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
        _database = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
    }
    public IMongoDatabase Database => _database;
}
