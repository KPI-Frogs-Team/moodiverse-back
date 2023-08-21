using AutoMapper;
using Moodiverse.DAL.Context;

namespace Moodiverse.BL.Services.Abstract;

public abstract class BaseService
{
    private protected readonly MoodiverseDbContext _context;
    private protected readonly IMapper _mapper;

    public BaseService(MoodiverseDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
}