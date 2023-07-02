namespace Moodiverse.WebAPI.Models.Common;

public abstract class BaseDomain
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}