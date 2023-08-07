

using С_Project.Controllers;
using Service.Helpers.Extentions;

AccountController accountController = new AccountController();
accountController.Register();

GroupController controller = new GroupController();

static void Menues()
{
    ConsoleColor.Cyan.WriteConsole("Choose one option for workng with app: 1 - Create group, 2 - Delete group, 3 - Edit group, 4 - Get group by id, 5 - Get all groups, 6 - Search group, 7 - Filter group," +
        " 8 - Create student, 9 - Delete student, 10 - Edit student, 11 - Get Student by id, 12 - Get all students, 13 - Search student, 14 - Sorting students");
}