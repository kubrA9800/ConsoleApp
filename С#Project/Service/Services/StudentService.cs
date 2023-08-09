using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Repository.Data;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private int _count = 1;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public void Create(Student student)
        {
            student.Id = _count;
            _studentRepository.Create(student);
            _count++;
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> GetAllByExpression(Expression<Func<Student, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public List<Student> SearchByName(string name, string surname)
        {
            return _studentRepository.SearchByFullName(name,surname);
        }
    }
}
