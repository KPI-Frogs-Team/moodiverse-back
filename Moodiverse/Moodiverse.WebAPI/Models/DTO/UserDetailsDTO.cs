namespace Moodiverse.WebAPI.Models.DTO;

public class UserDetailsDTO
{
    public string Username { get; set; }
    public string Email { get; set; }
    public int AvatarId { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid SexId { get; set; }
}