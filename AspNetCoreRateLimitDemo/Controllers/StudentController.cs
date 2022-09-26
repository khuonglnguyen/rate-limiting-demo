using Microsoft.AspNetCore.Mvc;
using RateLimiting.Common.Repository;

namespace AspNetCoreRateLimitDemo.Controllers
{
    [Route("students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("id")]
        public IActionResult GetStudentById(Guid id)
        {
            var student = _studentRepository.GetStudentById(id);
            return student is not null ? Ok(student) : NotFound();
        }

        [HttpGet("")]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentRepository.GetAllStudents());
        }

    }
}
