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
            return AddDbContext<Student>.datas.FindAll(m => m.FullName.Contains(name));
        }
    }
}
