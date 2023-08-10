using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T:BaseEntity
    {
        void Create(T entity);
         T Delete(int id);
        void Edit(T entity);
        List<T> GetAll();
        List<T> GetAllByExpression(Expression<Func<T, bool>> expression);
        T GetById(int id);
        
    }
}
