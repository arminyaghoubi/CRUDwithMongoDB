using MongoDB.Bson.Serialization.Attributes;

namespace CRUDwithMongoDB.Common.Models;

public class Book : BaseModel
{
    [BsonElement("Name")]
    public string BookName { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string Author { get; set; }
}
