﻿using Service.Services;
using Service.Services.Interfaces;
using System;
using Service.Helpers.Extentions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;
using Repository.Data;

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
                Group entity = new Group()
                {
                    Name = name,
                    Capacity = seatCount
                };
              
                _groupService.Create(entity);
                ConsoleColor.Cyan.WriteConsole("Group create success");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Seat count format is not correct, please try again ");
                goto SeatCount;
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
            var result = _groupService.GetAll();
            foreach (var item in result)
            {
                string data = $"{item.Id}-{item.Name}-{item.Capacity}";
                ConsoleColor.Green.WriteConsole(data);
            }
        }

        public List<Group> GetAllByExpression()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {

            ConsoleColor.Cyan.WriteConsole("Add group Id");
            Id: string IdStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(IdStr, out id);
            if (isCorrectId)
            {
                var result = _groupService.GetById(id);
                if (result == null)
                {
                    ConsoleColor.Red.WriteConsole(" Data not found, please write id again");
                    goto Id;
                }

                string data = $"{result.Id}-{result.Name}-{result.Capacity}";
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
           Group group = new();

          var result=_groupService.GetAll();
          foreach (var item in result)
            {
                if (item.Name.ToLower().Trim().Contains(text))
                {
                    Console.WriteLine($"{item.Id}{item.Name} {item.Capacity}");
                }
            }
        }

       
    }
}
