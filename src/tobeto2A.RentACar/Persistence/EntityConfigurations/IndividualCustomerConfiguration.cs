﻿//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Persistence.EntityConfigurations;
//public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
//{
//    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
//    {
//        builder.HasKey(i => i.Id);
//        builder.ToTable("IndividualCustomers");
//    }
//}
////IndividualCustomer




//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//namespace Persistence.EntityConfigurations
//{
//    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
//    {
//        public void Configure(EntityTypeBuilder<Customer> builder)
//        {
//            builder.HasKey(i => i.Id);
//            builder.ToTable("Customers");

//            // Customer - IndividualCustomer ilişkisini belirt
//            builder.HasOne(c => c.IndividualCustomers)
//                   .WithOne(ic => ic.Customer)
//                   .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId); // Customer'ın bağımlı taraf olduğunu belirt
//        }
//    }

//    public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
//    {
//        public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
//        {
//            builder.HasKey(i => i.Id);
//            builder.ToTable("IndividualCustomers");
//        }
//    }
//}
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.HasKey(i => i.Id);//PK->Id
        builder.ToTable("InvidualCustomers");//Hangi veritabanı tablosuyla eşleşeceğini belirt

        //InvidualCustomer - Customer ilişkisini belirt
        builder.HasOne(c => c.Customer)//bir KurumsalMüşteri yalnızca bir müşteri(customer) aittir 
               .WithOne(c => c.IndividualCustomers)//bir müşteri(Customer) yalnızca bir KurumsalMüşteri aittir 
               .HasForeignKey<IndividualCustomer>(c => c.CustomerId); //FK->CustomerId InvidualCustomer'ın bağımlı taraf olduğunu belirt
    }
}