namespace Lab11C.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public Student student  { get; set;}

        public Course course { get; set;}

        public DateTime date { get; set; }
    }
}
