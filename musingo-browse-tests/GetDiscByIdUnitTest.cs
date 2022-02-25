using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using MongoDB.Bson;
using Moq;
using musingo_browse_service.Data;
using musingo_browse_service.Dtos;
using musingo_browse_service.Handlers;
using musingo_browse_service.Models;
using musingo_browse_service.Profiles;
using musingo_browse_service.Queries;
using Xunit;

namespace musingo_browse_tests;

public class GetDiscByIdUnitTest
{
    private readonly Mock<IDiscRepository> _discRepositoryStub = new Mock<IDiscRepository>();
    private readonly IMapper _mapper =
        new Mapper(new MapperConfiguration(config => config.AddProfile(new DiscProfile())));
    private readonly Random _random = Random.Shared;


    [Fact]
    public async Task GetDiscByIdHandler_MatchFound_ReturnsDiscReadDto()
    {
        //Arrange
        
        var guid = Guid.NewGuid();

        var disc = new Disc()
        {
            Artist = "TomaszBand",
            Description = "Swietnaplytapolecam",
            Genre = Genre.Rock,
            Id = new ObjectId(),
            Name = "TomaszDisc",
            AverageScore = 3.4,
            DiscId = guid,
            DiscType = DiscType.Vinyl,
            PictureUrl = "www.hehe.up/cos.jpg",
            ReleaseDate = DateOnly.FromDateTime(DateTime.Today)
        };
        
        _discRepositoryStub.Setup(repository => repository.GetDiscById(guid)).ReturnsAsync(disc);
        var handler = new GetDiscByIdHandler(_discRepositoryStub.Object,_mapper);
        var query = new GetDiscByIdQuery(guid);
        
        //Act

        var res = await handler.Handle(query,new CancellationToken());

        //Assert

        res.Should().BeEquivalentTo(_mapper.Map<DiscReadDto>(disc));
    }
    
    [Fact]
    public async Task GetDiscByIdHandler_MatchNotFound_ReturnsNull()
    {
        //Arrange
        
        var guid = Guid.NewGuid();
        _discRepositoryStub.Setup(repository => repository.GetDiscById(guid))!.ReturnsAsync(null as Disc);
        var handler = new GetDiscByIdHandler(_discRepositoryStub.Object,_mapper);
        var query = new GetDiscByIdQuery(guid);
        
        //Act

        var disc = await handler.Handle(query,new CancellationToken());

        //Assert

        disc.Should().BeNull();
    }
}