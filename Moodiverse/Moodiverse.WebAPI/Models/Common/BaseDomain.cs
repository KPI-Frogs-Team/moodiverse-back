namespace Moodiverse.WebAPI.Models.Common;

public abstract class BaseDomain
{
    public int Id { get; set; }
    private DateTime _createdAt;

    public BaseDomain()
    {
        CreatedAt = UpdatedAt = DateTime.Now;
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = (value == DateTime.MinValue) ? DateTime.Now : value;
    }
    public DateTime UpdatedAt { get; set; }
}