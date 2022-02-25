using System;
using AutoMapper;
using Moq;
using musingo_browse_service.Data;
using musingo_browse_service.Profiles;

namespace musingo_browse_tests;

public class GetDiscsByQueryUnitTest
{
    private readonly Mock<IDiscRepository> _discRepositoryStub = new Mock<IDiscRepository>();
    private readonly IMapper _mapper =
        new Mapper(new MapperConfiguration(config => config.AddProfile(new DiscProfile())));
    private readonly Random _random = Random.Shared;
    
    //TODO: Test a few scenarios
    //UnitOfWork_StateUnderTest_ExpectedBehavior

}