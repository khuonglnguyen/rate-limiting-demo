using RateLimiting.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting.Common.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Dictionary<Guid, Student> _students = new ();
        public StudentRepository()
        {
            InitializeStudentSeed();
        }
        public List<Student> GetAllStudents()
        {
            return _students.Values.ToList();
        }

        public Student GetStudentById(Guid id)
        {
            return _students[id];
        }

        private void InitializeStudentSeed()
        {
            // Create 5 random students
            for(int i = 0; i < 5; i++)
            {
                var _id = Guid.NewGuid();
                _students.Add(_id, new Student
                (
                    _id,
                    $"Student-{i}",
                    $"Grade{i}"
                ));
            }
        }
    }
}
