using System.ComponentModel.DataAnnotations;
using Moodiverse.DAL.Entities.Abstract;

namespace Moodiverse.DAL.Entities;

public class User : BaseDomain
{
    [Required(ErrorMessage = "Username must be specified")]
    public string Username { get; set; } = null!;
    [Required(ErrorMessage = "Email must be specified")]
    public string Email { get; set; } = null!;
    public int? AvatarId { get; set; }
    
    [Required(ErrorMessage = "Password must be specified")]
    public string Password { get; set; } = null!;
    [Required]
    public string Salt { get; set; } = null!;
    [Required(ErrorMessage = "Birthdate must be specified")]
    public DateTime Birthdate { get; set; }
    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? SexId { get; set; }
    
    public virtual Sex? Sex { get; set; }
    public virtual Avatar? Avatar { get; set; }
}