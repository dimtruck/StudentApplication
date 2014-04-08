using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class Student
    {
        public Student(int id, String name, int Age = 6)
        {
            this.Id = id;
            this.Name = name;
            this.Age = Age;
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
