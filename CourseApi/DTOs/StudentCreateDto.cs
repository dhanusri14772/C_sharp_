using System.ComponentModel.DataAnnotations;

namespace CourseApi.DTOs
{
    public class StudentCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}