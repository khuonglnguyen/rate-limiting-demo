using CustomMiddleware.Decorators;
using Microsoft.AspNetCore.Mvc;
using RateLimiting.Common.Repository;

namespace CustomMiddleware.Controllers
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
        [LimitRequest(MaxRequests =2,TimeWindow =5)]
        public IActionResult GetStudentById(Guid id)
        {
            var student = "";
            return student is not null ? Ok(student) : NotFound();
        }

        [HttpGet("")]
        [LimitRequest(MaxRequests = 2, TimeWindow = 5)]
        public IActionResult GetAllStudents()
        {
            return Ok("sdsd");
        }
        
    }
}
