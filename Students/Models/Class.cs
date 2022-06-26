using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
