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
using Repository.Repositories;
using Repository.Data;
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

            if (!isCorrectAge)
            {
                ConsoleColor.Red.WriteConsole("Don't add  word for age");
            }

            ConsoleColor.Cyan.WriteConsole("Add group id");
        GroupId: string groupIdStr = Console.ReadLine();
            int groupId;
            bool isCorrectGroupId = int.TryParse(groupIdStr, out groupId);

            GroupService groupService = new();
            var group = groupService.GetById(groupId);

            if (isCorrectGroupId)
            {
                Student newStudent = new()
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    Group = group,
                };

                _studentService.Create(newStudent);

                ConsoleColor.Green.WriteConsole("Student successfully created");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Id format is not correct, please try again");
                goto GroupId;
            }

        }

        public void Delete()
        {
            
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            var result = _studentService.GetAll();
            foreach (var item in result)
            {
                string data = $"{item.Id}-{item.Name}-{item.Surname} {item.Age} {item.Group.Name}";
                ConsoleColor.Green.WriteConsole(data);
            }
        }

        public List<Student> GetAllByExpression()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            ConsoleColor.Cyan.WriteConsole("Add student Id");
            Id: string IdStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(IdStr, out id);
            if (isCorrectId)
            {
                var result = _studentService.GetById(id);
                if (result == null)
                {
                    ConsoleColor.Red.WriteConsole(" Data not found, please write id again");
                    goto Id;
                }

                string data = $"{result.Id}-{result.Name}-{result.Age}";
                ConsoleColor.Green.WriteConsole(data);

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add Id format again:");
                goto Id;
            }
        }

        public void SearchByName(string text)
        {
            var result = _studentService.GetAll();
            foreach (var item in result)
            {
                if (item.Name.ToLower().Trim().Contains(text))
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age}");
                }
            }
        }




    }
}
