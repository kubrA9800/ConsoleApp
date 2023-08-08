using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using Service.Helpers.Extentions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace С_Project.Controllers
{
    internal class StudentController
    {
        private readonly IStudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add student name");
            Name: string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("Student name can't be empty");
                goto Name;
            }

            
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllByExpression()
        {
            throw new NotImplementedException();
        }

        public Student GetById()
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchByName()
        {
            throw new NotImplementedException();
        }
    }
}
