using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Study2
{
    class Process
    {
        public static void Processing()
        {
            int students = 0;
            Console.Write("Введите количество студентов: ");
            students = Students.Studen(students);
            int[] age = new int[students];
            string[] name = new string[students];

            for (int i = 0; i < students; i++)
            {
                Console.Write("Введите имя: ");
                name[i] = NamesAndAges.Name();
                
                Console.Write("Введите возраст: ");
                age[i] = NamesAndAges.Ages();
            }

            Console.WriteLine($"Количество студентов: {students}");
            Thread.Sleep(2000);
            
            for (int i = 0; i < students; i++)
            {
                Thread.Sleep(600);
                Console.WriteLine($"Имя: {name[i]}.");
                Console.WriteLine($"Возраст: {age[i]}");
                Console.WriteLine();
                
            }

            
        }
    }
}
