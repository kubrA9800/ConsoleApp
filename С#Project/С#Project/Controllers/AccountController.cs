using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Service.Helpers.Extentions;

namespace С_Project.Controllers
{
    public class AccountController
    {

        public void Register()
        {
            ConsoleColor.Cyan.WriteConsole("Add username");
            Username: string username=Console.ReadLine();
            if (Regex.IsMatch(username, @"\d"))
            {
                ConsoleColor.Red.WriteConsole("Username can't contain digits, please try again");
                goto Username;        
            }
            ConsoleColor.Cyan.WriteConsole("Add surname");
            Surname: string surname=Console.ReadLine();
            if (Regex.IsMatch(surname, @"\d"))
            {
                ConsoleColor.Red.WriteConsole("Surname can't contain digits, please try again");
                goto Surname;
            }
            ConsoleColor.Cyan.WriteConsole("Add user's age");
            Age: string ageStr=Console.ReadLine();
            int age;
            bool isCorrectAge=int.TryParse(ageStr, out age);
            if (isCorrectAge)
            {
                ConsoleColor.Cyan.WriteConsole("Add user's email");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Age format is not correct, please try again");
                goto Age;
            }
            Email: string email=Console.ReadLine();
            if (Regex.IsMatch(email, @"@"))
            {
                ConsoleColor.Cyan.WriteConsole("Add password");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Email format is not correct, please try again");
                goto Email;
            }
            Password: string password1=Console.ReadLine();
            ConsoleColor.Cyan.WriteConsole("Confirm password");
            string password2=Console.ReadLine();
            if(password1==password2)
            {
                ConsoleColor.Green.WriteConsole("Register success");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Password is not correct, please try again");
                goto Password;
            }

        }
    }
}
