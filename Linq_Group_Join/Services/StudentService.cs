using Linq_Group_Join.Models;

namespace Linq_Group_Join.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students;
        private readonly List<Class> _classes;

        public StudentService()
        {
            _students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Zeynep", ClassId = 3 }
            };

            _classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Fen" },
                new Class { ClassId = 3, ClassName = "Türkçe" }
            };
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public List<Class> GetAllClasses()
        {
            return _classes;

        }
    }
}