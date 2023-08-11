

using С_Project.Controllers;
using Service.Helpers.Extentions;
using Domain.Models;

RegisterLogin();
AccountController accountController = new AccountController();
GroupController groupController = new GroupController();
StudentController studentController = new StudentController();


while(true)
{
    string accountStr=Console.ReadLine();
    int operation;
    bool isCorrectOption=int.TryParse(accountStr, out operation);
    if (isCorrectOption)
    {
        if (operation == 1)
        {
            accountController.Register();
            RegisterLogin();         
        }

        else if (operation==2)
        {
            accountController.Login();
            Menues();
            while (true)
            {
                Operation: string menuOperationStr = Console.ReadLine();
                int menuOperation;
                bool isCorrectMenuOperation = int.TryParse(menuOperationStr, out menuOperation);

                if (isCorrectMenuOperation)
                {
                    switch (menuOperation)
                    {
                        case 1:
                            groupController.Create();
                            break;
                        case 2:
                            groupController.Delete();
                            break;
                        case 3:
                            groupController.Edit();
                            break;
                        case 4:
                            groupController.GetById();
                            break;
                        case 5:
                            groupController.GetAll();
                            break;
                        case 6:
                            groupController.SearchByName();
                            break;
                        case 7:
                            groupController.Sort();
                            break;
                        case 8:
                            studentController.Create();
                            break;
                        case 9:
                            studentController.Delete();
                            break;
                        case 10:
                            studentController.Edit();
                            break;
                        case 11:
                            studentController.GetById();
                            break;
                        case 12:
                            studentController.GetAll();
                            break;
                        case 13:
                            studentController.SearchByFullName();
                            break;
                        case 14:
                            studentController.Sort();
                            break;
                        default:
                            ConsoleColor.Red.WriteConsole("Operation not found");
                            break;
                            
                    }
            
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Operation format is not correct");
                    goto Operation;
                }
            }

        }
        else
        {
            ConsoleColor.Red.WriteConsole("Select correct operation");
        }

    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is not correct");
    }

}
static void RegisterLogin()
{
    ConsoleColor.Blue.WriteConsole("Choose one option: 1- Register, 2 - Login");
}


Menu: static void Menues()
{
    ConsoleColor.Blue.WriteConsole("Please choose one option for workng with app: \n 1 - Create group \n 2 - Delete group \n 3 - Edit group \n 4 - Get group by id \n 5 - Get all groups \n 6 - Search group\n 7 - Sort group \n " +
        " \n 8 - Create student \n 9 - Delete student \n 10 - Edit student \n 11 - Get Student by id \n 12 - Get all students \n 13 - Search student \n 14 - Sort students");
}