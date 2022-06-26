using StudentsAPI.Models;

namespace StudentsAPI.Repository.IRepository
{
    public interface IScoreRepository
    {
        ICollection<Score> GetByStudentId(int id);
    }
}
