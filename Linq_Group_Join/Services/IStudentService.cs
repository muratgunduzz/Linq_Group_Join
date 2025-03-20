using Linq_Group_Join.Models;

namespace Linq_Group_Join.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        List<Class> GetAllClasses();
    }
}
