using ConsoleEF.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleEF
{
    internal class program
    {
        public static void InsertProduct()
        {
            using (var dbcon = new ProdContext()) //Inherited Dbcontext
            {
                Product product = new Product();
                product.Name = "Lyril";
                dbcon.Add(product);
                product = new Product();
                product.Name = "Medimix";
                dbcon.Add(product);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void InsertStandard() 
        {
            using (var dbcon = new ProdContext())
            {
                Standard stu = new Standard();
                //stu.StandardId = 1;
                
                stu.StandardName= "1st Grade";
                dbcon.Add(stu);
                dbcon.SaveChanges();
            }
        }
        public static void InsertStudent()
        {
            using(var dbcon = new ProdContext())
            {
                Student stud = new Student();
                //stud.StudentID = 100;
                stud.StandardRefId = 1;
                stud.StudentName = "Naman";
                dbcon.Add(stud);

                dbcon.SaveChanges();
            }
        }
        public static void ReadProduct()
        {
            using (var dbcon = new ProdContext()) { 
                List<Product> prds = dbcon.Products.ToList();
                foreach (var pr in prds) //var pr in dbcon.products
                {
                    Console.WriteLine(pr.Name+ " "+pr.Id);
                }
                
            }

        }
        public static void UpdateProduct()
        {
            using (var dbcon = new ProdContext()){
                Product? prd = dbcon.Products.Find(4);
                prd.Name = "Lux";
                dbcon.SaveChanges();
            }
        }
        public static void DeleteProduct()
        {
            using (var dbcon = new ProdContext())
            {
                Product ?prod = dbcon.Products.Find(2);
                dbcon.Products.Remove(prod); //dbcon.Products.Remove()
                dbcon.SaveChanges() ;
            }
        }
        public static void Main(string[] args)
        {
            //InsertProduct(); //To insert product
            ReadProduct();
            //UpdateProduct();
            //DeleteProduct();
            //InsertStandard();
            //InsertStudent();
            Console.WriteLine("Success");


        }
    }
}
