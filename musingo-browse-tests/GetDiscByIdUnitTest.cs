using System;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using musingo_browse_service.Data;
using musingo_browse_service.Profiles;
using Xunit;

namespace musingo_browse_tests;

public class GetDiscByIdUnitTest
{
    private readonly Mock<IDiscRepository> _discRepository = new Mock<IDiscRepository>();
    private readonly IMapper _mapper =
        new Mapper(new MapperConfiguration(config => config.AddProfile(new DiscProfile())));
    private readonly Random _random = Random.Shared;


    [Fact]
    public async Task GetDiscByIdHandler_MatchFound_ReturnsDiscReadDto()
    {
        //Arrange
        
        
        
        //Act
        
        
        
        //Assert
    }
    
    [Fact]
    public async Task GetDiscByIdHandler_MatchNotFound_ReturnsNull()
    {
        //Arrange
        
        
        
        //Act
        
        
        
        //Assert
    }
}