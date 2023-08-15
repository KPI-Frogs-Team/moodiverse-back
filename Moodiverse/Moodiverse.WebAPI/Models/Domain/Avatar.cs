using Moodiverse.WebAPI.Models.Common;

namespace Moodiverse.WebAPI.Models.Domain;

public class Avatar : BaseDomain
{
    public string URL { get; set; }  = null!;
}