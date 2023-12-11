using System.ComponentModel.DataAnnotations;

namespace StudentMS.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(100)]
        public string Contact { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        public string Info { get; set; }
    }
}
