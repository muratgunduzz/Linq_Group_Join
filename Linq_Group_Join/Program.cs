using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Linq_Group_Join.Services;  
using Linq_Group_Join.Models;  

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IStudentService, StudentService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/students", (IStudentService studentService) => studentService.GetAllStudents());

app.Run();
