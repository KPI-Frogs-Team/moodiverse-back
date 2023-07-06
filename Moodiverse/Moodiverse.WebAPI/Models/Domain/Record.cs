using Moodiverse.WebAPI.Models.Common;

namespace Moodiverse.WebAPI.Models.Domain;

public class Record : BaseDomain
{
    public int UserId { get; set; }
    public int MoodId { get; set; }
    public string? Text { get; set; }
    
    public virtual User User { get; set; }
    public virtual Mood Mood { get; set; }
}