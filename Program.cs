using EFcoreP1.Context;
using EFcoreP1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFcoreP1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(EnterpriseContext Context = new EnterpriseContext())
            {
                #region Department Insert
                //List<Department> Depts = new List<Department>();

                //Depts.Add( new Department() { Name = "HR" });
                //Depts.Add(new Department() { Name = "SD" });

                //Console.WriteLine(Context.Entry(Depts[0]).State);
                //Context.Departments.AddRange(Depts);
                //Console.WriteLine(Context.Entry(Depts[0]).State);

                //Context.SaveChanges();
                //Console.WriteLine(Context.Entry(Depts[0]).State); 
                #endregion

                #region Department Select
                //var Result = from d in Context.Departments
                //             select d;

                //foreach (var item in Result)
                //    Console.WriteLine($"{item.Name} :: {item.DeptID} :: {item.DateOfCreation} :: {item.Employees}");

                #endregion

                #region Department update
                //var Result = (from d in Context.Departments
                //              where d.DeptID == 10
                //              select d).FirstOrDefault();
                //Result.Name = "PR";
                //Context.SaveChanges();

                //var depts = from d in Context.Departments
                //             select d;

                //foreach (var item in depts)
                //    Console.WriteLine($"{item.Name} :: {item.DeptID} :: {item.DateOfCreation} :: {item.Employees}");

                #endregion

                #region Department Delete
                //var deletedDept = Context.Departments.Where(d => d.DeptID == 10).FirstOrDefault();
                //Context.Departments.Remove(deletedDept);

                //var depts = from d in Context.Departments
                //            select d;

                //foreach (var item in depts)
                //    Console.WriteLine($"{item.Name} :: {item.DeptID} :: {item.DateOfCreation} :: {item.Employees}");

                //Context.SaveChanges();

                //foreach (var item in depts)
                //    Console.WriteLine($"{item.Name} :: {item.DeptID} :: {item.DateOfCreation} :: {item.Employees}");

                #endregion




                //Employee E1 = new Employee() { Name = "Janna", Age = 22, Email="J@gmail.com" };
                //Employee E2 = new Employee() { Name = "Joy", Salary = 3000, Age = 25, Email = "joy@gmail.com", };



            }
        }
    }
}
