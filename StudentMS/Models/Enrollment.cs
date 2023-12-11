using System.ComponentModel.DataAnnotations;

namespace StudentMS.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        [Required]
        [StringLength(100)]
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        public int Amount { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
    }
}
