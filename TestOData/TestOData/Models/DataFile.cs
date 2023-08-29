using System.ComponentModel.DataAnnotations;

namespace TestOData.Models
{
    public class DataFile
    {
        [Key]
        public int FileId { get; set; }
        [Required]
        public string FileName { get; set; }
    }
}
