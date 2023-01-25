﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InatechTrainingTasks.Day5
{
    internal class Task5b
    {

        double sal, bonus;

        public void Sales(double s)
        {
            sal = s;
            double bonus = sal * 20 / 100;
            double total = sal + bonus;
            Console.WriteLine("Employee salary:{0}", sal);
            Console.WriteLine("Employee bonus:{0}", bonus);
            Console.WriteLine("Employee total salary:{0}", total);

        }

        public void Production(double s)
        {
            sal = s;
            double bonus = sal * 10 / 100;
            double total = bonus + sal;
            Console.WriteLine("Employee salary:{0}", sal);
            Console.WriteLine("Employee bonus:{0}", bonus);
            Console.WriteLine("Employee total salary:{0}", total);

        }

    }

    class Emp : Task5b
    {

        public static void Main(string[] args)
        {
            Task5b obj = new Task5b();
            Console.WriteLine("Enter EmpID:");
            int EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter years of experience:");
            int YrsOfExp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary in two digit precision");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your department:");
            Console.WriteLine("1.Sales & Marketing Department");
            Console.WriteLine("2.Production Department");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {

                case 1:
                    Console.WriteLine("***************");
                    Console.WriteLine("Employee ID :{0}", EmpID);
                    Console.WriteLine("Employee name:{0}", name);
                    Console.WriteLine("Employee gender:{0}", gender);
                    Console.WriteLine("Employee experience{0}", YrsOfExp);
                    obj.Sales(s);
                    break;
                case 2:
                    Console.WriteLine("***************");
                    Console.WriteLine("Employee ID :{0}", EmpID);
                    Console.WriteLine("Employee name:{0}", name);
                    Console.WriteLine("Employee gender:{0}", gender);
                    Console.WriteLine("Employee experience{0}", YrsOfExp);
                    obj.Production(s);

                    break;

            }

        }

    }
}
