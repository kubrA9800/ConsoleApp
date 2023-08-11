using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain.Models;
using Service.Helpers.Extentions;
using Service.Services;
using Service.Services.Interfaces;

namespace С_Project.Controllers
{    
    public class AccountController
    {
        private readonly IAccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Register()
        {
            ConsoleColor.DarkYellow.WriteConsole("Add Name");
            Username: string username=Console.ReadLine();
            if (Regex.IsMatch(username, @"[^A-Za-z]"))
            {
                ConsoleColor.Red.WriteConsole("Username format is not correct, please try again");
                goto Username;        
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                ConsoleColor.Red.WriteConsole("Username can't be empty");
                goto Username;
            }
            ConsoleColor.DarkYellow.WriteConsole("Add surname");
            Surname: string surname=Console.ReadLine();
            if (Regex.IsMatch(surname, @"[^A-Za-z]"))
            {
                ConsoleColor.Red.WriteConsole("Surname format is not correct, please try again");
                goto Surname;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                ConsoleColor.Red.WriteConsole("Surname can't be empty");
                goto Surname;
            }
            ConsoleColor.DarkYellow.WriteConsole("Add user's age");
            Age: string ageStr = Console.ReadLine();
            int age;
            bool isCorrectAge=int.TryParse(ageStr, out age);
            if (isCorrectAge)
            {
                ConsoleColor.DarkYellow.WriteConsole("Add user's email");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Age format is not correct, please try again");
                goto Age;
            }
            Email: string email=Console.ReadLine();
            if (Regex.IsMatch(email, @"@"))
            {
                ConsoleColor.DarkYellow.WriteConsole("Add password");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Email format is not correct, please try again");
                goto Email;
            }
            Password: string password1=Console.ReadLine();
            ConsoleColor.DarkYellow.WriteConsole("Confirm password");
            string password2=Console.ReadLine();
            if(password1==password2)
            {
                User user1 = new User()
                {
                    Name = username,
                    Surname = surname,
                    Age = age,
                    Email = email,
                    Password = password1,
                };

                _accountService.Register(user1);
                
                ConsoleColor.Green.WriteConsole("Register success");

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Password is not correct, please try again");
                goto Password;
            }

        }



        
        public void Login()
        {
            
            ConsoleColor.DarkYellow.WriteConsole("Add email");
            Email: string email=Console.ReadLine();

            if (string.IsNullOrEmpty(email))
            {
                ConsoleColor.Red.WriteConsole("Can't be empty");
                goto Email;
            }

            bool isSymbool = Regex.IsMatch(email, @"@");
            if ( isSymbool==false)
            {
                ConsoleColor.Red.WriteConsole("Email format is not correct");
                goto Email;
            }
            ConsoleColor.DarkYellow.WriteConsole("Add password");
            string password = Console.ReadLine();
            User user2 = new User()
            {
                Password = password,
                Email = email
            };

            bool result = _accountService.Login(user2);
            if (result)
            {
                ConsoleColor.Green.WriteConsole("Login success");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Email or password is wrong");
                goto Email;
            }


            
        }
        
       
    }
}
