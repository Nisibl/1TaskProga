using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLogic
{
    public class Logic
    {
        private List<Student> students { get; set; }
            = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student(name, speciality, group));
        }

        public void DeleteStudent(string name, string speciality, string group)
        {
            students.Remove( new Student(name, speciality, group));
        }

        public string[][] GetAllStudents()
        {
            string[][] result = new string[students.Count][];

            string[] currentStudent = new string[3]; // 3 = количество необходимых параметров: имя, специальность, группа
            
            for( int i = 0; i < students.Count; i++ )
            {
                result[i] = new string[] { students[i].GetName(), 
                    students[i].GetSpeciality(), students[i].GetGroup() };
            }

            return result;
        }

        public Dictionary<string, int> GetCountStudentsOfEverySpeciality()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var student in students)
            {
                string specialityOfStudent = student.GetSpeciality();
                if ( result.ContainsKey(specialityOfStudent) )
                {
                    result[student.GetSpeciality()]++;
                }
                else
                {
                    result.Add(specialityOfStudent, 1 );
                }
            }

            return result;
        }
    }
}
