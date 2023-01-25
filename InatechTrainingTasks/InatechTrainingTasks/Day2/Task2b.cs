using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InatechTrainingTasks.Day2
{
    internal class Task2b
    {
        public static void Main()
        {
            int mult = 1;
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                mult = n * i;
                Console.WriteLine("{0} * {1}={2}", n, i, mult);
            }
        }
    }
}
