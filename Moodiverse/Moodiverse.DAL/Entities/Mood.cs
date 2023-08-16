using System.ComponentModel.DataAnnotations;
using Moodiverse.DAL.Entities.Abstract;

namespace Moodiverse.DAL.Entities;

public class Mood : BaseDomain
{
    public string Name { get; set; } = null!;
    public string PictureURL { get; set; } = null!;
    [Range(0, 10)]
    public int Points { get; set; } 
}