using MediatR;
using musingo_browse_service.Dtos;

namespace musingo_browse_service.Queries;

public class GetDiscByIdQuery : IRequest<DiscReadDto>
{
    public Guid DiscId { get; set; }
    
    public GetDiscByIdQuery(Guid guid)
    {
        DiscId = guid;
    }
}