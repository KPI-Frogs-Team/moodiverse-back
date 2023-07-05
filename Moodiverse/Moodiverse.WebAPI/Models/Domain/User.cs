using System.ComponentModel.DataAnnotations;
using Moodiverse.WebAPI.Models.Common;

namespace Moodiverse.WebAPI.Models.Domain;

public class User : BaseDomain
{
    [Required(ErrorMessage = "Username must be specified")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Email must be specified")]
    public string Email { get; set; }
    [Required]
    public int AvatarId { get; set; }
    [Required(ErrorMessage = "Password must be specified")]
    public string Password { get; set; }
    [Required]
    public string Salt { get; set; }
    [Required(ErrorMessage = "Birthdate must be specified")]
    public DateTime Birthdate { get; set; }
    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? SexId { get; set; }
    
    public virtual Sex Sex { get; set; }
    public virtual Avatar Avatar { get; set; }
}