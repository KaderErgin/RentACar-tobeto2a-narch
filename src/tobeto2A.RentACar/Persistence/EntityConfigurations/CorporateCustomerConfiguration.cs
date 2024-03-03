
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
    {
        public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
        {
            builder.HasKey(cc => cc.Id);//PK->Id
            builder.ToTable("CorporateCustomers");//CorporateCustomer entity'sinin hangi tabloyla eşleşeceğini belirt

            //her bir CorporateCustomer kaydının bir müşteriye (yani bir Customer kaydına) bağlı olması gerektiğini belirtir. 
            builder.Property(cc => cc.CustomerId)
                   .IsRequired();//.IsRequired() bu özelliğin(CustomerId) NULL olamayacağını yani  her zaman bir değere sahip olması gerektiğini belirtir.


            builder.HasOne(cc => cc.Customer)//bir BireyselMüşteri yalnızca bir müşteri(customer) aittir 
                   .WithOne(c => c.CorporateCustomer)//bir müşteri(Customer) yalnızca bir BireyselMüşteri aittir
                   .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);//FK->CustomerId,CorporateCustomer'ın bağımlı taraf olduğunu belirt
        }
    }
}
