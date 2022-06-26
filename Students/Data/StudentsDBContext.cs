using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models;

namespace StudentsAPI.Data
{
    public class StudentsDBContext : DbContext
    {
        public StudentsDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>().ToTable("Score");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Class>().ToTable("Class");
            //modelBuilder.Entity<Student>().ToTable("Student");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Class>().HasData(
                new Class { Id = 1, Name = "II" }
                );

            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Telugu" },
                new Subject { Id = 2, Name = "English" },
                new Subject { Id = 3, Name = "Hindi" },
                new Subject { Id = 4, Name = "EVS" },
                new Subject { Id = 5, Name = "ICT" },
                new Subject { Id = 6, Name = "Maths" }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Ganesh", LastName = "K", ClassId = 1, RollNumber = "RN1", BirthDate = new DateTime(2001, 12, 31), FatherName= "Ganesh Father", MotherName= "Ganesh Mother",Address="115 Hill crest Avenue, Hyderabad.",Phone="1234567891",Email="ganesh@abc.com", BloodGroup="O +ve" },
                new Student { Id = 2, FirstName = "Suresh", LastName = "S", ClassId = 1, RollNumber = "RN2", BirthDate = new DateTime(2001, 11, 15), FatherName = "Suresh Father", MotherName = "Suresh Mother", Address="2425 Matheson Blvd, Hyderabad.", Phone = "1115556667", Email = "suresh@abc.com", BloodGroup = "B +ve" },
                new Student { Id = 3, FirstName = "Mahesh", RollNumber = "RN3", ClassId = 1, BirthDate = new DateTime(2001, 12, 31), FatherName = "Mahesh Father", MotherName = "Mahesh Mother", Address = "115 Hill crest Avenue, Hyderabad.", Phone = "2225556667", Email = "mahesh@abc.com", BloodGroup = "O +ve" },
                new Student { Id = 4, FirstName = "Ajar", LastName = "Abbas", RollNumber = "RN4", ClassId = 1, BirthDate = new DateTime(2001, 11, 15), FatherName = "Ajar Father", MotherName = "Ajar Mother", Address = "115 Hill crest Avenue, Hyderabad.", Phone = "9885412345", Email = "mahesh@abc.com", BloodGroup = "A +ve" }
                );

            modelBuilder.Entity<Score>().HasData(
                new Score { Id = 1, StudentId = 1, SubjectId = 1, Marks = 90 },
                new Score { Id = 2, StudentId = 1, SubjectId = 2, Marks = 99 },
                new Score { Id = 3, StudentId = 1, SubjectId = 3, Marks = 100 },
                new Score { Id = 4, StudentId = 1, SubjectId = 4, Marks = 85 },
                new Score { Id = 5, StudentId = 1, SubjectId = 5, Marks = 79 },
                new Score { Id = 6, StudentId = 1, SubjectId = 6, Marks = 79 },

                 new Score { Id = 7, StudentId = 2, SubjectId = 1, Marks = 65 },
                new Score { Id = 8, StudentId = 2, SubjectId = 2, Marks = 75 },
                new Score { Id = 9, StudentId = 2, SubjectId = 3, Marks = 90 },
                new Score { Id = 10, StudentId = 2, SubjectId = 4, Marks = 85 },
                new Score { Id = 11, StudentId = 2, SubjectId = 5, Marks = 79 },
                new Score { Id = 12, StudentId = 2, SubjectId = 6, Marks = 79 },

                 new Score { Id = 13, StudentId = 3, SubjectId = 1, Marks = 45 },
                new Score { Id = 14, StudentId = 3, SubjectId = 2, Marks = 65 },
                new Score { Id = 15, StudentId = 3, SubjectId = 3, Marks = 35 },
                new Score { Id = 16, StudentId = 3, SubjectId = 4, Marks = 55 },
                new Score { Id = 17, StudentId = 3, SubjectId = 5, Marks = 55 },
                new Score { Id = 18, StudentId = 3, SubjectId = 6, Marks = 79 },

                 new Score { Id = 19, StudentId = 4, SubjectId = 1, Marks = 20 },
                new Score { Id = 20, StudentId = 4, SubjectId = 2, Marks = 35 },
                new Score { Id = 21, StudentId = 4, SubjectId = 3, Marks = 45 },
                new Score { Id = 22, StudentId = 4, SubjectId = 4, Marks = 55 },
                new Score { Id = 23, StudentId = 4, SubjectId = 5, Marks = 65 },
                new Score { Id = 24, StudentId = 4, SubjectId = 6, Marks = 79 }
                );

        }
    }
}
