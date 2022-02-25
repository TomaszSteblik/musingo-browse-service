using AutoMapper;
using MediatR;
using musingo_browse_service.Data;
using musingo_browse_service.Dtos;
using musingo_browse_service.Queries;

namespace musingo_browse_service.Handlers;

public class GetDiscsByQueryHandler : IRequestHandler<GetDiscsByQueryQuery,DiscReadDto>
{
    private readonly IDiscRepository _discRepository;
    private readonly IMapper _mapper;

    public GetDiscsByQueryHandler(IDiscRepository discRepository, IMapper mapper)
    {
        _discRepository = discRepository;
        _mapper = mapper;
    }
    
    public Task<DiscReadDto> Handle(GetDiscsByQueryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}