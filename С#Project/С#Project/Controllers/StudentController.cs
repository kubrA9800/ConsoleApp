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
using System.Text.RegularExpressions;

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
            if (Regex.IsMatch(name, @"\d"))
            {
                ConsoleColor.Red.WriteConsole("Name can't contain digits, please try again");
                goto Name;
            }

            ConsoleColor.Cyan.WriteConsole("Add student surname");
            Surname: string surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname))
            {
                ConsoleColor.Red.WriteConsole("Student surname can't be empty");
                goto Surname;
            }
            if (Regex.IsMatch(surname, @"\d"))
            {
                    ConsoleColor.Red.WriteConsole("Surname can't contain digits, please try again");
                    goto Surname;
            }

            ConsoleColor.Cyan.WriteConsole("Add student age");
            Age: string ageStr = Console.ReadLine();
            int age;
            bool isCorrectAge = int.TryParse(ageStr, out age);
            if (isCorrectAge)
            {
                ConsoleColor.Green.WriteConsole("Student successfully created");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Age format is not correct, please try again");
                goto Age;
            }

        }

        public void Delete()
        {
            
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
