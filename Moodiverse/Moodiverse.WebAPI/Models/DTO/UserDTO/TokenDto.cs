namespace Moodiverse.WebAPI.Models.DTO.UserDTO;

public class TokenDto
{
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
}