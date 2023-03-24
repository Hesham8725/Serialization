using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public void Print()
        {
            Console.WriteLine("Print Fun");
        }
    }
}
