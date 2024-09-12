using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        private string name { get; set; } // зачем нужны модификаторы доступа
        private string speciality { get; set; }
        private string group { get; set; }

        public Student() { }
        public Student(string name, string speciality, string group) 
        {
            this.name = name;
            this.speciality = speciality;
            this.group = group;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSpeciality()
        {
            return speciality;
        }
        public string GetGroup()
        {
            return group;
        }
    }
}
