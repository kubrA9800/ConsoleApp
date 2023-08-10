using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IGroupService
    {
        void Create(Group entity);
        Group  Delete(int id);
        void Edit(Group entity);
        List<Group> GetAll();
        List<Group> GetAllByExpression(Expression<Func<Group, bool>> expression);
        Group GetById(int id);

        List<Group> SearchByName(string name);

        


    }
}
