using MongoDB.Bson.Serialization.Attributes;

namespace CRUDwithMongoDB.Common.Models;

public abstract class BaseModel
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
}