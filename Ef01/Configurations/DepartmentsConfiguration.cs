using FluentApis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Configurations
{
    class DepartmentsConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);

            builder.Property(D => D.Id)
             .UseIdentityColumn(10, 10);


            builder.Property(D => D.Name)
             .HasColumnName("DepartmentName")
             .HasMaxLength(50)
             .IsRequired(false);

            

        }
    }
}
