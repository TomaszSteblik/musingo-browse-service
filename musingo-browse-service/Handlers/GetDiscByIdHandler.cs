using AutoMapper;
using MediatR;
using musingo_browse_service.Data;
using musingo_browse_service.Dtos;
using musingo_browse_service.Queries;

namespace musingo_browse_service.Handlers;

public class GetDiscByIdHandler : IRequestHandler<GetDiscByIdQuery,DiscReadDto>
{
    private readonly IDiscRepository _discRepository;
    private readonly IMapper _mapper;

    public GetDiscByIdHandler(IDiscRepository discRepository, IMapper mapper)
    {
        _discRepository = discRepository;
        _mapper = mapper;
    }

    public Task<DiscReadDto> Handle(GetDiscByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}