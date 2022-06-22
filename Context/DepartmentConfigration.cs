using EFcoreP1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreP1.Context
{
    class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            
                builder.Property(D => D.DeptID).UseIdentityColumn(10, 10);
                builder.Property(D => D.Name).HasDefaultValue("Anonymous Dept");
                builder.Property(D => D.DateOfCreation).HasDefaultValue(DateTime.Now);
            
        }
    }
}
