﻿//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
//{
//    public void Configure(EntityTypeBuilder<Customer> builder)
//    {
//        builder.HasKey(i => i.Id);//PK->Id
//        builder.ToTable("Customers");//Hangi veritabanı tablosuyla eşleşeceğini belirt

//        // Customer - CorporateCustomer ilişkisini belirt//
//        builder.HasOne(c => c.CorporateCustomers)//
//               .WithOne(c => c.Customer)//
//               .HasForeignKey<Customer>(c => c.CustomerId); // Customer'ın bağımlı taraf olduğunu belirt//
//    }
//}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);//PK->Id
            builder.ToTable("Customers");//Hangi veritabanı tablosuyla eşleşeceğini belirt
            // Customer - IndividualCustomer ilişkisini belirt//
            builder.HasOne(c => c.IndividualCustomer)
                   .WithOne(ic => ic.Customer)
                   .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);// Customer'ın bağımlı taraf olduğunu belirt
            // Customer - CorporateCustomer ilişkisini belirt//
            builder.HasOne(c => c.CorporateCustomer)
                   .WithOne(cc => cc.Customer)
                   .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);
        }
    }
}
