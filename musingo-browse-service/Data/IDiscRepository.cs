using musingo_browse_service.Models;

namespace musingo_browse_service.Data;

public interface IDiscRepository
{
    Task<Disc> GetDiscById(Guid discId);
}