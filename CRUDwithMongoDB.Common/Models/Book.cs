using MongoDB.Bson.Serialization.Attributes;

namespace CRUDwithMongoDB.Common.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Name")]
    public string BookName { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string Author { get; set; }
}