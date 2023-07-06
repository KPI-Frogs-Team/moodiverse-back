namespace Moodiverse.WebAPI.Models.DTO.RecordDTO;

public class CreateRecordDto
{
    public int MoodId { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; set; }
}