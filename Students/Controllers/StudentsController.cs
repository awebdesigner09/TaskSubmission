using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Models;
using StudentsAPI.Repository.IRepository;

namespace StudentsAPI.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepo;
        public StudentsController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Student>))]
        public IActionResult All()
        {
            var students = _studentRepo.GetAll();
            if (students == null) return NotFound();
            return Ok(students);
        }

        [HttpGet("{studentId:int}", Name = "GetStudentById")]
        [ProducesResponseType(200, Type = typeof(Student))]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public IActionResult GetStudentById(int studentId)
        {
            var student = _studentRepo.GetById(studentId);
            if (student == null) return NotFound();
            return Ok(student);
        }
    }
}
