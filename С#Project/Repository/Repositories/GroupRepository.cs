using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public List<Group> SearchByName(string name)
        {
            List<Group> data =  AddDbContext<Group>.datas.Where(m => m.Name.Contains(name)).ToList();
            if (data.Any())
            {
                return data;
            }
            return null;
        }

       

        public List<Group> Sort()
        {
            return AddDbContext<Group>.datas.OrderBy(m => m.Capacity).ToList();
        }

     
    }
}
