namespace CourseApi.DTOs
{
    public class EnrollmentReadDto
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public DateTime EnrolledAt { get; set; }
    }
}