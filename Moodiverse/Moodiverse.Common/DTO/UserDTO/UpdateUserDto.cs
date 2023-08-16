namespace Moodiverse.Common.DTO.UserDTO;

public class UpdateUserDto
{
    public string Username { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Sex { get; set; } = null!;
    public string Birthdate { get; set; } = null!;
}