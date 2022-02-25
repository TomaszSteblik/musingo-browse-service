using AutoMapper;
using MediatR;
using musingo_browse_service.Data;
using musingo_browse_service.Dtos;
using musingo_browse_service.Queries;

namespace musingo_browse_service.Handlers;

public class GetDiscByIdHandler : IRequestHandler<GetDiscByIdQuery,DiscReadDto>
{
    public GetDiscByIdHandler(IDiscRepository discRepository, IMapper mapper)
    {
        throw new NotImplementedException();
    }

    public Task<DiscReadDto> Handle(GetDiscByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}