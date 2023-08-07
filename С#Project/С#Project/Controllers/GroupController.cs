using Service.Services;
using Service.Services.Interfaces;
using System;
using Service.Helpers.Extentions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace С_Project.Controllers
{
    public class GroupController
    {
        private readonly IGroupService _groupService;

        public GroupController()
        {
            _groupService = new GroupService();
        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add group name");
            Name: string name=Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("Group's name can't be empty");
                goto Name;
            }

            ConsoleColor.Cyan.WriteConsole("Add group seat count");
            SeatCount: string seatCountStr=Console.ReadLine();
            int seatCount;

            bool isCorrectSeatcount=int.TryParse(seatCountStr, out seatCount);
            if (isCorrectSeatcount)
            {
                Group group =new Group();
                group.Name = name;
                group.Capacity= seatCount;

                _groupService.Create(group);
                ConsoleColor.Cyan.WriteConsole("Group create success");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Seat count format is not correct, please try again ");
                goto SeatCount;
            }

        }
    }
}
