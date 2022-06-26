﻿using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
