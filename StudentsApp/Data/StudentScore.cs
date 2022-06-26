namespace StudentsApp.Data
{
    public class StudentScore
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Subject Subject { get; set; }
        public int Marks { get; set; }

    }
}
