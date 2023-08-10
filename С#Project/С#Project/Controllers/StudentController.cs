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
using System.ComponentModel.DataAnnotations;

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
            ConsoleColor.Cyan.WriteConsole("Add student fullname");
            Name: string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("Student fullname can't be empty");
                goto Name;
            }
            if (Regex.IsMatch(name, @"\d"))
            {
                ConsoleColor.Red.WriteConsole("Fullname can't contain digits, please try again");
                goto Name;
            }

            ConsoleColor.Cyan.WriteConsole("Add student age");
            Age: string ageStr = Console.ReadLine();
            int age;
            bool isCorrectAge = int.TryParse(ageStr, out age);

            if (!isCorrectAge)
            {
                ConsoleColor.Red.WriteConsole("Don't add letter for age");
                goto Age;
            }

            ConsoleColor.Cyan.WriteConsole("Add student address");
            Address: string address= Console.ReadLine();
            if (string.IsNullOrWhiteSpace(address))
            {
                ConsoleColor.Red.WriteConsole("Student address can't be empty");
                goto Address;
            }


            ConsoleColor.Cyan.WriteConsole("Add student phone");
            Phone: string phoneStr = Console.ReadLine();
            int phone;
            bool isCorrectPhone = int.TryParse(phoneStr, out phone);

            if (!isCorrectPhone)
            {
                ConsoleColor.Red.WriteConsole("Don't add letter for phone");
                goto Phone;
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
                    FullName = name,
                    Age = age,
                    Address = address,
                    Phone=phone,
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
            Console.WriteLine("Add id to delete student");
            Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idStr, out id);
            if (isCorrectId)
            {
                var result = _studentService.GetById(id);
                if (result is null)
                {
                    Console.WriteLine("Data not found");
                    goto Id;
                }
                _studentService.Delete(id);
                ConsoleColor.Green.WriteConsole("Student is deleted");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add correct id format");
                goto Id;
            }
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
                string data = $"{item.Id} {item.FullName} {item.Age} {item.Address} {item.Phone} {item.Group.Name}";
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

                string data = $"{result.Id} {result.FullName} {result.Age} {result.Address} {result.Phone}";
                Console.WriteLine(data);

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add Id format again:");
                goto Id;
            }
        }

        public void SearchByName(string fullName )
        {
            var result = _studentService.GetAll();
            foreach (var item in result)
            {
                if (item.FullName.ToLower().Trim().Contains(fullName))
                {
                    Console.WriteLine($"{item.Id} {item.FullName} {item.Age} {item.Address} {item.Phone}");
                }
            }
        }




    }
}
