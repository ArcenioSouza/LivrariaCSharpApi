using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LivrariaCSharpApi.Models
{
    public class Livros
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Title { get; set; }

        [BsonElement("author")]
        public string? Author { get; set; }

        [BsonElement("gender")]
        public string? Gender { get; set; }

        [BsonElement("qtdpages")]
        public int QtdPages { get; set; }
    }
}
