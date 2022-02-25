using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace musingo_browse_service.Models;

public class Disc
{
    [BsonId]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }
    [BsonElement("discId")]
    public Guid DiscId { get; set; }
    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("pictureUrl")]
    public string PictureUrl { get; set; }
    [BsonElement("description")]
    public string Description { get; set; }
    [BsonElement("artist")]
    public string Artist { get; set; }
    [BsonElement("releaseDate")]
    public DateOnly ReleaseDate { get; set; }
    [BsonElement("averageScore")]
    public double AverageScore { get; set; }
    [BsonElement("genre")]
    public Genre Genre { get; set; }
    [BsonElement("discType")]
    public DiscType DiscType { get; set; }
}