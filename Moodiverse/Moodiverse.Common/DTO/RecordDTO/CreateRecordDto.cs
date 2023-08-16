namespace Moodiverse.Common.DTO.RecordDTO;

public class CreateRecordDto
{
    public int MoodId { get; set; }
    public string Text { get; set; } = null!;
    public DateTime Date { get; set; }
}