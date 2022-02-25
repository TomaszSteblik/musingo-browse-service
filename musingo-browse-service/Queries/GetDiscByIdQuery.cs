using MediatR;
using musingo_browse_service.Dtos;

namespace musingo_browse_service.Queries;

public class GetDiscByIdQuery : IRequest<DiscReadDto>
{
    public GetDiscByIdQuery()
    {
        throw new NotImplementedException();
    }
}