using EFcoreP1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreP1.Context
{
    class EnterpriseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server = .; Database= EnterpriseV1; Integrated Security = true;");

        public DbSet<Employee> Employees { get; set;}
        public DbSet<Department> Departments { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>(E => {
            //    E.Property(D => D.DeptID).UseIdentityColumn(10, 10);
            //    E.Property(D => D.Name).HasDefaultValue("Anonymous Dept");
            //    E.Property(D => D.DateOfCreation).HasDefaultValue(DateTime.Now);
            //});

            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigration());

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
