//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Persistence.EntityConfigurations;
//public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
//{
//    public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
//    {
//        builder.HasKey(i => i.Id);
//        builder.ToTable("CorporateCustomers");
//    }
//}

using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EntityConfigurations
{
    public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
    {
        public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
        {
            builder.HasKey(i => i.Id);
            builder.ToTable("CorporateCustomers");

            // CorporateCustomer - Customer ilişkisini belirt
            builder.HasOne(c => c.Customer)
                   .WithOne(c => c.CorporateCustomers)
                   .HasForeignKey<CorporateCustomer>(c => c.CustomerId); // CorporateCustomer'ın bağımlı taraf olduğunu belirt
        }
    }
}