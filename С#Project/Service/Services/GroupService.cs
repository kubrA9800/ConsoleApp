using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly GroupRepository _groupRepostory;

        public void Create(Group entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Group entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Group entity)
        {
            throw new NotImplementedException();
        }

        public void Filter()
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            return _groupRepostory.GetAll();
        }

        public List<Group> GetAllByExpression(Expression<Func<Group, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Group GetById(int id)
        {
            return _groupRepostory.GetById(id);
        }

        public List<Group> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
