using musingo_browse_service.Models;

namespace musingo_browse_service.Data;

public class DiscRepository : IDiscRepository
{
    public DiscRepository()
    {
        
    }

    public Task<Disc> GetDiscById(Guid discId)
    {
        throw new NotImplementedException();
    }
}