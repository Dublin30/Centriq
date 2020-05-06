using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> student = new List<string>();
            bool newStudent = false;
            bool reload = false;
            bool exit = false;
            do
            {

           
            Console.WriteLine("\nWould you like to enter a Student:\n" +
                        "Y) Yes\n" +
                        "N) No\n");
            

            ConsoleKey userchoice = Console.ReadKey(true).Key;
            Console.Clear();
            switch (userchoice)
            {
                case ConsoleKey.Y:
                    Console.WriteLine("Please enter another student");
                    student.Add(Console.ReadLine());
                    reload = true;
                    break;
                case ConsoleKey.N:
                    Console.WriteLine(student);
                    break;
                default:
                    Console.WriteLine("Please choose an option");
                    break;
            }

        } while (!exit && !reload);

            //do
            //{
            //    Console.WriteLine("Please enter the students first name");
            //    student.Add();

            //} while (newStudent);

            //Console.WriteLine("Please enter a students name.");
            //string student1 = Console.ReadLine();

        }
    }
}
