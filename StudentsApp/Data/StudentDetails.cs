namespace StudentsApp.Data
{
    public class StudentDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Class Class { get; set; }
        public string? RollNumber { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
    }
}
