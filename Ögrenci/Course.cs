using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    
    public class Course
    {
        public Course()
        {

        }
        public Course(int ıd, string name)
        {
            this.Id = ıd;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
