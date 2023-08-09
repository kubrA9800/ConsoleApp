using Domain.Models;
using Repository.Data;
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
        private readonly IGroupRepository _groupRepository;
        private int _count = 1;
        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }
       
        public void Create(Group group)
        {
            group.Id = _count;
            _groupRepository.Create(group);
            _count++;
        }

        public void Delete(Group group)
        {
            throw new NotImplementedException();
        }

        public void Edit(Group group)
        {
            throw new NotImplementedException();
        }

        public void Filter()
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }

        public List<Group> GetAllByExpression(Expression<Func<Group, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Group GetById(int id)
        {
            return _groupRepository.GetById(id);
        }

        public List<Group> SearchByName(string name)
        {
            return _groupRepository.SearchByName(name);
        }
    }
}
