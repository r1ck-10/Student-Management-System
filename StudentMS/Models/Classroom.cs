using System.ComponentModel.DataAnnotations;

namespace StudentMS.Models
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string RoomNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Schedule { get; set; }
        [Required]
        public int StudentNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Course { get; set; }
        public string Description { get; set; }
    }
}
