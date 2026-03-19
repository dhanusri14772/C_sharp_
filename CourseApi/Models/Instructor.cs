using System.ComponentModel.DataAnnotations;
namespace CourseApi.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}