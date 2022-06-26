using Microsoft.EntityFrameworkCore;
using StudentsAPI.Data;
using StudentsAPI.Models;
using StudentsAPI.Repository.IRepository;

namespace StudentsAPI.Repository
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly StudentsDBContext _db;

        public ScoreRepository(StudentsDBContext db)
        {
            _db = db;
        }

        public ICollection<Score> GetByStudentId(int id) => _db.Scores.Include(s => s.Subject).Where(s => s.StudentId == id).ToList();
       
    }
}
