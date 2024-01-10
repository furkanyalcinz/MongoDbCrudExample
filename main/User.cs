// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class User
{
    [BsonId]
    public ObjectId _id { get; set; }
    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("surname")]
    public string Surname { get; set; }
    [BsonElement("birth_year")]
    public int BirthYear { get; set; }
    [BsonElement("is_active")]
    public bool IsActive { get; set; }
}
