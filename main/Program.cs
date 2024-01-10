// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Driver;

User user = new()
{
    Name = "Emre",
    Surname = "Yalçın",
    BirthYear = 2001,
    IsActive = true
    
};
var uri = "mongodb://localhost:27017/";

var client = new MongoClient(uri);

var collection = client.GetDatabase("TestDatabase").GetCollection<User>("TestCollection");
var res = collection.AsQueryable().ToList();
// var userDocument = new BsonDocument
// {
//     { "_id", user._id },
//     { "name", user.Name },
//     { "surname", user.Surname },
//     { "birth_year", user.BirthYear },
//     { "is_active", user.IsActive }
// }; 
collection.InsertOne(user);
Console.WriteLine(collection);