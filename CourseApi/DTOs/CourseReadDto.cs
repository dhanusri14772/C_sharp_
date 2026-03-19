namespace CourseApi.DTOs
{
    public class CourseReadDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }
   
        public int InstructorId {get; set;}
    }
}