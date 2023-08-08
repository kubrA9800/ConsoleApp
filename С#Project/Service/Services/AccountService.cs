using Domain.Models;
using Repository.Data;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        
        public bool Login(User user)
        {
            var result=AddDbContext<User>.datas.FirstOrDefault(m=>m.Email==user.Email && m.Password==user.Password);
            if (result!=null )
            {
                if(result.Email==user.Email && result.Password == user.Password)
                {
                    return true;
                } 

            }return false;
        }

        private int _count;
        public void Register(User user)
        {
            user.Id = _count;
            AddDbContext<User>.datas.Add(user);
            _count++;     
        }
    }
}
