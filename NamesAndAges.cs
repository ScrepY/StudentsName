using System;
using System.Collections.Generic;
using System.Text;

namespace Study2
{
    class NamesAndAges
    {
        public static string Name()
        {
            
            string names = Console.ReadLine();
            return names;
        }

        public static int Ages()
        {
            int ages = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return ages;
        }

    }
}
