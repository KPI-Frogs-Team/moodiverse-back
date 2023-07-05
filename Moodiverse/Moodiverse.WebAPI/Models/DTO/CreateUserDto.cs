namespace Moodiverse.WebAPI.Models.DTO;

public class CreateUserDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public int AvatarId { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
}