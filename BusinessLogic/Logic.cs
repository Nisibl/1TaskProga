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

        public string[][] GetAllStudentsFormatArrayOfArrays()
        {
            string[][] result = new string[students.Count][];

            for( int i = 0; i < students.Count; i++ )
            {
                result[i] = new string[] { students[i].name, 
                    students[i].speciality, students[i].group };
            }

            return result;
        }
        public Student[] GetAllStudentsFormatArrayOfStudents()
        {
            Student[] result = new Student[students.Count];

            for (int i = 0; i < students.Count; i++)
            {
                result[i] = students[i];
            }

            return result;
        }

        public Dictionary<string, int> GetCountStudentsOfEverySpeciality()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var student in students)
            {
                string specialityOfStudent = student.speciality;
                if ( result.ContainsKey(specialityOfStudent) )
                {
                    result[student.speciality]++;
                }
                else
                {
                    result.Add(specialityOfStudent, 1 );
                }
            }

            return result;
        }

        public void FillTableWithDemoData()
        {
            for (int i = 0; i < 10; i++)
            {
                AddStudent(Convert.ToString(i), "Повар", "ИН20-45л");
            }
            for (int i = 0; i < 20; i++)
            {
                AddStudent(Convert.ToString(i), "Программист", "КИ23-21б");
            }
            for (int i = 0; i < 2; i++)
            {
                AddStudent(Convert.ToString(i), "Моряк", "ФИ26-7б");
            }
        }
    }
}
