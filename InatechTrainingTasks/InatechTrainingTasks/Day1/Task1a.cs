using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a.Day1
{
    internal class Task1a
    {
        public static int BillCal(int units)
        {
            if (units <= 200)
            {
                return units * 2;
            }
            else if (units <= 350)
            {
                return (200 * 2) + (units - 200) * 3;
            }
            else if (units <= 500)
            {
                return (200 * 2) + (150 * 3) + (units - 350) * 5;
            }
            else if (units > 500)
            {
                return (200 * 2) + (150 * 3) + (150 * 5) + (units - 500) * 7;
            }
            return 0;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the units:");
            int units = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BillCal(units));

        }

    }
}