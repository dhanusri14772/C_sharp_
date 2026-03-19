using System.ComponentModel.DataAnnotations;
namespace CourseApi.Models
{
    public class Student
{
    public int Id {get; set;}
    [Required]
    public string name {get; set;}
    [Required]
    public string Email{get; set;} 
    public ICollection<Enrollment> Enrollments {get; set;}
}
}
