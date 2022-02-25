using MediatR;
using musingo_browse_service.Dtos;
using musingo_browse_service.Models;

namespace musingo_browse_service.Queries;

public class GetDiscsByQueryQuery : IRequest<DiscReadDto>
{
    public string? Artist { get; set; }
    public string? Name { get; set; }
    public Genre? Genre { get; set; }
    public DiscType? DiscType { get; set; }
    public DateOnly? ReleaseDate { get; set; }
    
    public GetDiscsByQueryQuery(string? artist = null, string? name = null, Genre? genre = null, 
                                DiscType? discType = null, DateOnly? releaseDate = null)
    {
        Artist = artist;
        Name = name;
        Genre = genre;
        DiscType = discType;
        ReleaseDate = releaseDate;
    }
}