
using Ef01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.Configurations
{
    class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> E)
        {
            E.HasKey(D => D.Id);

            E.Property(D => D.Id)
          .UseIdentityColumn(10, 10);

            E.Property(D => D.Name)
            .HasColumnName("Department Name")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .HasDefaultValue("Test")
            .IsRequired(false);


            E.Property(D => D.DateOfCreation);
            
        }
    }
}
