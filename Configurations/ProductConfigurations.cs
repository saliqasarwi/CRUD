using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CRUD.Configurations
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProdId);
            builder.Property(p => p.Name).HasColumnType("varchar(60)");
        }
    }
}
