using Linq_Group_Join.Models;

namespace Linq_Group_Join.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
            // Örnek veri
            _students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Zeynep", ClassId = 3 }
            };
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }
    }
}