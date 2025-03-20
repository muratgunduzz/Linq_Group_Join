using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Linq_Group_Join.Services;
using Linq_Group_Join.Models;
using System.Linq;
using Linq_Group_Join.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IStudentService, StudentService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/students", (IStudentService studentService) => studentService.GetAllStudents());

app.MapGet("/classstudents", (IStudentService studentService) =>
{
    var students = studentService.GetAllStudents();
    var classes = studentService.GetAllClasses();

    var classStudentJoin = from c in classes
                           join s in students on c.ClassId equals s.ClassId into studentGroup
                           select new
                           {
                               ClassName = c.ClassName,
                               Students = studentGroup
                           };

    var result = "";
    foreach (var classWithStudents in classStudentJoin)
    {
        result += $"Sýnýf: {classWithStudents.ClassName}\n";
        foreach (var student in classWithStudents.Students)
        {
            result += $"  Öðrenci: {student.StudentName}\n";
        }
    }
    return result;
});

app.Run();
