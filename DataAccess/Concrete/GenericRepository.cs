using DataAccess.Abstract;
using MongoDB.Driver;

namespace DataAccess.Concrete;

public abstract class GenericRepository<T> where T: class
{
    protected IMongoCollection<T> _mongoCollection;
    public GenericRepository(MongodbContext mongodbContext, string collectionName)
    {
       _mongoCollection = mongodbContext.Database.GetCollection<T>(collectionName);
    }
    public async Task Insert(T entity)
    {
        await _mongoCollection.InsertOneAsync(entity);
    }
    // public async Task Update(string id, T entity)
    // {
    //     await _mongoCollection.ReplaceOneAsync(x=> x.Id == id , entity);
    // }




}
