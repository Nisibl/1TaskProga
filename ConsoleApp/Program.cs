using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessLogic;

namespace ConsoleApp
{
    internal class Program
    {
        static Logic logic = new Logic();
        static void Main(string[] args)
        {
            ClearConsoleBySavingInstructions();
            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddNewStudent();
                        break;
                    case "2":
                        DeleteStudent();
                        break;
                    case "3":
                        PrintStudentTable();
                        break;
                    case "4":
                        PrintGistogram();
                        break;
                    case "5":
                        logic.FillTableWithDemoData();
                        break;
                    default: 
                        Console.WriteLine("Введена некорректная команда");
                        break;
                }
            }
        }

        static private void AddNewStudent()
        {
            (string name, string speciality, string group) = InterviewUser();

            logic.AddStudent(name, speciality, group);
            ClearConsoleBySavingInstructions();
        }

        static private void DeleteStudent()
        {
            (string name, string speciality, string group) = InterviewUser();
            logic.DeleteStudent(name, speciality, group);
        }

        static private (string name, string speciality, string group) InterviewUser()
        {
            CompletelyClearConsole();
            Console.WriteLine("Введи имя студента");
            string name = Console.ReadLine();
            CompletelyClearConsole();

            Console.WriteLine("Введи Специальность студента");
            string speciality = Console.ReadLine();
            CompletelyClearConsole();

            Console.WriteLine("Введи Группу студента");
            string group = Console.ReadLine();
            CompletelyClearConsole();

            return (name, speciality, group);
        }

        static private void PrintStudentTable()
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Name", "Speciality", "Group");
            Console.WriteLine(new string('-', 50));

            string[][] students = logic.GetAllStudents();
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-20}", 
                    students[i][0], students[i][1], students[i][2]);
            }
        }

        static private void PrintGistogram()
        {
            Dictionary<string, int> fullnessSpecialties = logic.GetCountStudentsOfEverySpeciality();

            char fullSymbol = '▓';
            string specialtyText;
            string scale;

            int maxValue = GetMaxValue(fullnessSpecialties);

            foreach (var i in fullnessSpecialties)
            {
                specialtyText = i.Key + "(" + Convert.ToString(i.Value) + ")" + ":";
                scale = new string(fullSymbol, GetIndexInRange(maxValue, 40, i.Value));
                Console.WriteLine($"{specialtyText,-20} {scale}");
            }
        }

        static private int GetMaxValue(Dictionary<string, int> fullnessSpecialties)
        {
            int maxValue = 0;
            foreach (var i in fullnessSpecialties)
            {
                if (maxValue < i.Value)
                {
                    maxValue = i.Value;
                }
            }
            return maxValue;
        }

        static private int GetIndexInRange(int maxValue, int maxScale, int currentValue)
        {
            double percentRelativeMaxValue = (double)currentValue / maxValue;

            int result = (int)(maxScale * percentRelativeMaxValue);
            if( result < 1 && currentValue > 0)
            {
                result = 1;
            }

            return result;
        }

        static private void ClearConsoleBySavingInstructions()
        {
            Console.Clear();
            Console.WriteLine("Введите код желаемой команды" +
                    "\n 1 - Создать студента" +
                    "\n 2 - Удалить студента " +
                    "\n 3 - Вывести весь список в таблицу" +
                    "\n 4 - Вывести гистограмму: распределение студентов по специальностям" +
                    "\n 5 - Автоматически заполнить таблицу данными для демонстрации работы");
        }

        static private void CompletelyClearConsole()
        {
            Console.Clear();
        }
    }
}
