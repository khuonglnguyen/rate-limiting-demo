using RateLimiting.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting.Common.Repository
{
    public interface IStudentRepository
    {
        Student GetStudentById(Guid id);
        List<Student> GetAllStudents();
    }
}
