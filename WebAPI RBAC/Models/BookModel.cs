using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebAPI_RBAC.Models;

public class BookModel
{
    [BsonId]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}