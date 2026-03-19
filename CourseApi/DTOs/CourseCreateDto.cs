namespace CourseApi.DTOs
{
    public class CourseCreateDto
    {
        public string Title { get; set; }

        public int Credits { get; set; }

        public int InstructorId { get; set; }
    }
}