using DataAccess.Abstract;
using MongoDB.Driver;

namespace DataAccess.Concrete;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    
    public UserRepository(MongodbContext mongodbContext) : base(mongodbContext, "TestCollection")
    {
        
    }
    public List<User> Get()
    {
        return _mongoCollection.AsQueryable().ToList();
    }
    
}
