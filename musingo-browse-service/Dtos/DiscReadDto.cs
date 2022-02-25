using musingo_browse_service.Models;

namespace musingo_browse_service.Dtos;

public class DiscReadDto
{
    public Guid DiscId { get; set; }
    public string Name { get; set; }
    public string PictureUrl { get; set; }
    public string Description { get; set; }
    public string Artist { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public double AverageScore { get; set; }
    public Genre Genre { get; set; }
    public DiscType DiscType { get; set; }
}