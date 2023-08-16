namespace Moodiverse.Common.DTO.RecordDTO;

public class UpdateRecordDto
{
    public int MoodId { get; set; }
    public string Text { get; set; } = null!;
    public DateTime Date { get; set; }
}