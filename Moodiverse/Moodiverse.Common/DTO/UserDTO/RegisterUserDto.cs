namespace Moodiverse.Common.DTO.UserDTO;

public class RegisterUserDto
{
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Birthdate { get; set; } = null!;
}