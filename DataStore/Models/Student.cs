using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Models
{
    public class Student
    {
        public Student( string name, List<Marks> marks)
        {
          
            Name = name;
            Marks = marks;
        }

        public Student()
        {
          
            Name = string.Empty;
            Marks = new List<Marks>();            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Marks> Marks { get; set; }

    }
}
