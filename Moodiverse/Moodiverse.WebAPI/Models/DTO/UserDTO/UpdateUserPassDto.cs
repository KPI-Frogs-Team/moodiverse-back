namespace Moodiverse.WebAPI.Models.DTO.UserDTO;

public class UpdateUserPassDto
{
    public string OldPassword { get; set; } = null!;
    public string NewPassword { get; set; } = null!;
}