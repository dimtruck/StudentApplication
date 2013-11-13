using Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public IQueryable<Course> ListAll()
        {
            return new List<Course>(){
                new Course()
            }.AsQueryable();
        }
    }
}
