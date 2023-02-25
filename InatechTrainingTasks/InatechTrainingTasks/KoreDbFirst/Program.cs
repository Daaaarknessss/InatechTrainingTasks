using KoreDbFirst.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreDbFirst
{
    public class Program
    {
        public static void InsertDept()
        {
            using(var dbcon = new DivSambarContext())
            {
                Department dept = new Department();
                dept.DepartmentName = "Computer Science";
                dbcon.Add(dept);
                dbcon.SaveChanges();
            }
        }
        public static void Main(string[] args)
        {
            //InsertDept();
            InsertEmp();
        }
        public static void InsertEmp()
        {
            using (var dbcon = new DivSambarContext())
            {
                Employee emp = new Employee();
                emp.EmpName = "Padmavathy";
                var daaate =Convert.ToDateTime( "08/03/2002");
                emp.DateofBirth= daaate;
                emp.Designation = "Assistant Professor";
                emp.Gender= "F";
                emp.DeptId = 51;
                dbcon.Add(emp);
                dbcon.SaveChanges();
            }

        }
    }
}
