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

        public Student Delete(int id)
        {
            return _studentRepository.Delete(id);
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public List<Student> SearchByName(string fullName)
        {
            return _studentRepository.SearchByFullName(fullName);
        }

        public List<Student> Sort()
        {
            return _studentRepository.Sort();
        }
    }
}
