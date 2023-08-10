﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public  interface IStudentRepository : IBaseRepository<Student>
    {
        List<Student>SearchByFullName(string fullName);

        List<Student> Sort();
    }
}
