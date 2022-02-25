using Microsoft.AspNetCore.Mvc;

namespace musingo_browse_service.Controllers;

[Route("api/b/[controller]")]
[ApiController]
public class DiscsController : ControllerBase
{
    [HttpGet("{discId}")]
    public async Task<ActionResult> GetDiscById(Guid discId)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task<ActionResult> GetDiscsByQuery()
    {
        ///api/b/Disc?name=„name”?artist=„artist”?countPerPage=20?page=3 ..etc
        throw new NotImplementedException();
    }
    
    
}