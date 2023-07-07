namespace MusicalSoulmates.Models;

using System.ComponentModel.DataAnnotations;

public class BaseDataTranslation
{
    public BaseData BaseData { get; set; }
    [Required]
    public int BaseDataId { get; set; }
    [Required]
    public string Lang { get; set; }
    public string Title { get; set; }
}
