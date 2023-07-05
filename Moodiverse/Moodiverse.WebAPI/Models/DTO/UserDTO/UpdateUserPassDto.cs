namespace Moodiverse.WebAPI.Models.DTO.UserDTO;

public class UpdateUserPassDto
{
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
}