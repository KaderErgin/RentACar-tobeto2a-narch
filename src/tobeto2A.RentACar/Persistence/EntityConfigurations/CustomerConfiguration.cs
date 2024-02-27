﻿//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Persistence.EntityConfigurations;
//public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
//{
//    public void Configure(EntityTypeBuilder<Customer> builder)
//    {
//        builder.HasKey(i => i.Id);
//        builder.ToTable("Customers");
//    }
//}

using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(i => i.Id);
        builder.ToTable("Customers");

        // Customer - CorporateCustomer ilişkisini belirt
        builder.HasOne(c => c.CorporateCustomers)
               .WithOne(c => c.Customer)
               .HasForeignKey<Customer>(c => c.CustomerId); // Customer'ın bağımlı taraf olduğunu belirt
    }
}