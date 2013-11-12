using Domain.Objects;
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
            throw new NotImplementedException();
        }
    }
}