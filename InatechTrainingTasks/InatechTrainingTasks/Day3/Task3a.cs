using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InatechTrainingTasks.Day3
{
    internal class Task3a
    {
        public void Add2nos(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub2nos(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    class Task3aD : Task3a
    {
        public void Mul2nos(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Div2nos(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Main()
        {
            int choice;
            Task3aD obj = new Task3aD();
            Console.WriteLine("Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Add2nos(a, b);
                    break;
                case 2:
                    obj.Sub2nos(a, b);
                    break;
                case 3:
                    obj.Mul2nos(a, b);
                    break;
                case 4:
                    obj.Div2nos(a, b);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;

            }

        }

    }
}
