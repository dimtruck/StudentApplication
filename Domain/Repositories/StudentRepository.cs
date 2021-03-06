﻿using Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public IQueryable<Student> ListAll()
        {
            return new List<Student>(){
                new Student(1, "Mike Jones", 15),
                new Student(2, "Sally Hanes")
            }.AsQueryable();
        }
    }
}