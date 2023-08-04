using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        void Create(Student entity);
        void Delete(Student entity);
        void Edit(Student entity);
        List<Student> GetAll();
        List<Student> GetAllByExpression(Expression<Func<Student, bool>> expression)
        Student GetById(int id);
        List<Student> SearchByName(string name);

    }
}
