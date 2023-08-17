using Moodiverse.DAL.Entities.Abstract;

namespace Moodiverse.DAL.Entities;

public class Avatar : BaseDomain
{
    public string URL { get; set; }  = null!;
}