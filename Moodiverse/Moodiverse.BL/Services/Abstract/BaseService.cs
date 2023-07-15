using Moodiverse.WebAPI.Data;

namespace Moodiverse.BL.Services.Abstract;

public abstract class BaseService
{
    private protected readonly MoodiverseDbContext _context;

    public BaseService(MoodiverseDbContext context)
    {
        _context = context;
    }
}