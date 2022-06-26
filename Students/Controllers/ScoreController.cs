using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Models;
using StudentsAPI.Repository.IRepository;

namespace StudentsAPI.Controllers
{
    [Route("api/score")]
    [ApiController]
    public class ScoreController : Controller
    {
        private readonly IScoreRepository _scoreRepo;
        public ScoreController(IScoreRepository scoreRepo)
        {
            _scoreRepo = scoreRepo;
        }

        [HttpGet("{studentId:int}", Name = "GetScoresByStudentId")]
        [ProducesResponseType(200, Type = typeof(List<Score>))]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public IActionResult GetScoresByStudentId(int studentId)
        {
            var scores = _scoreRepo.GetByStudentId(studentId);
            if (scores == null || scores.Count == 0) return NotFound();
            return Ok(scores);
        }
    }
}
