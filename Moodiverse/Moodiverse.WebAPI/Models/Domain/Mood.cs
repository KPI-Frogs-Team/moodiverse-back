using System.ComponentModel.DataAnnotations;
using Moodiverse.WebAPI.Models.Common;

namespace Moodiverse.WebAPI.Models.Domain;

public class Mood : BaseDomain
{
    public string Name { get; set; } = null!;
    public string PictureURL { get; set; } = null!;
    [Range(0, 10)]
    public int Points { get; set; } 
}