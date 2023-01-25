using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InatechTrainingTasks.Day4
{
    public abstract class Calculator
    {
        public abstract void Add2Nos(int a, int b);
        public abstract void Sub2Nos(int a, int b);
        public abstract void Mul2Nos(int a, int b);
        public abstract void Div2Nos(int a, int b);


    }
    internal class Task4b : Calculator
    {
        public override void Add2Nos(int a, int b)
        {
            Console.WriteLine("The addition is: {0}", a + b);
        }
        public override void Sub2Nos(int a, int b)
        {
            Console.WriteLine("The Subtraction is: {0}", a - b);
        }
        public override void Mul2Nos(int a, int b)
        {
            Console.WriteLine("The Multiplication is: {0}", a * b);
        }
        public override void Div2Nos(int a, int b)
        {
            Console.WriteLine("The Division is: {0}", a / b);
        }
        public static void Main()
        {
            Task4b obj = new Task4b();
            Console.WriteLine("Enter 2 Nos:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            obj.Add2Nos(a, b);
            obj.Sub2Nos(a, b);
            obj.Mul2Nos(a, b);
            obj.Div2Nos(a, b);

        }
    }
}
