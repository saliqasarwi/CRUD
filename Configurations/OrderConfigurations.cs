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
    internal class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o=>o.OrdId);
            builder.Property(o => o.Address).HasColumnType("varchar(30)");
            builder.Property(o => o.createdAt).HasComputedColumnSql("GETDATE()");
        }
    }
}
