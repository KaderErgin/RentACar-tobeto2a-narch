﻿
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
    {
        public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
        {
            builder.HasKey(ic => ic.Id);
            builder.ToTable("IndividualCustomers");
            //her bir IndividualCustomer kaydının bir müşteriye (yani bir Customer kaydına) bağlı olması gerektiğini belirtir. 
            builder.Property(ic => ic.CustomerId)
                   .IsRequired();//.IsRequired() bu özelliğin(CustomerId) NULL olamayacağını yani  her zaman bir değere sahip olması gerektiğini belirtir.
            
            //InvidualCustomer - Customer ilişkisini belirt
            builder.HasOne(ic => ic.Customer)//bir KurumsalMüşteri yalnızca bir müşteri(customer) aittir 
                   .WithOne(c => c.IndividualCustomer)//bir müşteri(Customer) yalnızca bir KurumsalMüşteri aittir 
                   .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);//FK->CustomerId InvidualCustomer'ın bağımlı taraf olduğunu belirt
        }
    }
}
