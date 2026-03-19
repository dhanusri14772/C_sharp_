using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public int Credits { get; set; }

        // Foreign Key
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}