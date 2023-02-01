using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InatechTrainingTasks.Day2
{
    internal class Task2d
    {
        public float percentage(float tot)
        {
            float perc = tot / 500 * 100;
            return perc;
        }
        public static void Main()
        {
            float tot = 0, perc;
            int[] ar = new int[5];
            Console.WriteLine("Enter the Marks for your subjects:");
            for (int i = 0; i < 5; i++)
                ar[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
                tot += ar[i];
            Task2d obj = new Task2d();
            perc = obj.percentage(tot);
            Console.WriteLine("the total is: {0}", tot);
            Console.WriteLine("the percentage is: {0}", perc);

        }

    }
}
