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
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public List<Student> SearchByFullName(string name)
        {
            List<Student> data = AddDbContext<Student>.datas.Where(m => m.FullName.Contains(name)).ToList();
            if (data.Any())
            {
                return data;
            }
            return null;
        }

        public List<Student> Sort()
        {
            return AddDbContext<Student>.datas.OrderBy(m => m.Age).ToList();
        }
    }
}
