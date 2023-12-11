using System.ComponentModel.DataAnnotations;

namespace StudentMS.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        [Required]
        [StringLength(100)]
        public string TeacherName { get; set; }
        [Required]
        public int CoursePrice { get; set; }
        public string CourseDescription { get; set; }
    }
}
