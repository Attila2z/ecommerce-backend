using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceBackend.Models
{
    public class Listing
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}