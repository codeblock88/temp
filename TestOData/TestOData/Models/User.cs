using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestOData.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }

        //Navigations
        [ForeignKey("FileRefNavigation")]
        public int? DataFileRef { get; set; }
        public DataFile? FileRefNavigation { get; set; }
    }
}
