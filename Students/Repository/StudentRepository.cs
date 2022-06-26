using Microsoft.EntityFrameworkCore;
using StudentsAPI.Data;
using StudentsAPI.Models;
using StudentsAPI.Repository.IRepository;
using StudentsAPI.ViewModel;

namespace StudentsAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsDBContext _db;

        public StudentRepository(StudentsDBContext db)
        {
            _db = db;
        }

        public ICollection<StudentGist> GetAll() => _db.Students.Select(s => new StudentGist { Id = s.Id, RollNumber = s.RollNumber, FirstName = s.FirstName, LastName = s.LastName, Class = s.Class.Name}).ToList();

        public Student GetById(int id) => _db.Students.Include(s => s.Class).FirstOrDefault(s => s.Id == id);
    }
}
