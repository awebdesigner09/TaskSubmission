using StudentsAPI.Models;
using StudentsAPI.ViewModel;

namespace StudentsAPI.Repository.IRepository
{
    public interface IStudentRepository
    {
        ICollection<StudentGist> GetAll();
        Student GetById(int id);
    }
}
