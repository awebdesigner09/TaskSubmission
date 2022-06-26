using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAPI.Models
{
    
    public class Student
    {
        [Key]
        public int Id   { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        public string? RollNumber { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string Phone { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string? BloodGroup { get; set; }

    }
}
