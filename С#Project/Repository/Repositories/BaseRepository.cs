using Domain.Common;
using Repository.Repositories.Interfaces;
using System;
using Repository.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T:BaseEntity
    {
        public void Create(T entity)
        {
            AddDbContext<T>.datas.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return AddDbContext<T>.datas.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllByExpression(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

    }
}
