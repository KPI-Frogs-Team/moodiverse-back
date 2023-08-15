namespace Moodiverse.WebAPI.Models.DTO.RecordDTO;

public class GetRecordDto
{
    public string Emoji { get; set; } = null!;
    public string Text { get; set; } = null!;
    public DateTime Date { get; set; }
}