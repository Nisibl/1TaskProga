using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public string name;
        public string speciality;
        public string group;

        public Student() { }
        public Student(string name, string speciality, string group) 
        {
            this.name = name;
            this.speciality = speciality;
            this.group = group;
        }
    }
}
