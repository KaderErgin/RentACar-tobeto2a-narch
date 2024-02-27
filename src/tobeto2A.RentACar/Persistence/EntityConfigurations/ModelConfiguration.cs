using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(i => i.Id);
            builder.ToTable("Models");
        }
    }
}
//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//namespace Persistence.EntityConfigurations
//{
//    public class ModelConfiguration : IEntityTypeConfiguration<Model>
//    {
//        public void Configure(EntityTypeBuilder<Model> builder)
//        {
//            builder.HasKey(i => i.Id);
//            builder.ToTable("Models");

//            // Brand ile olan ilişkiyi belirt
//            builder.HasOne(m => m.Brand)
//                   .WithMany()
//                   .HasForeignKey(m => m.BrandId);

//            // Fuel ile olan ilişkiyi belirt
//            builder.HasOne(m => m.Fuel)
//                   .WithMany()
//                   .HasForeignKey(m => m.FuelId);

//            // Transmission ile olan ilişkiyi belirt
//            builder.HasOne(m => m.Transmission)
//                   .WithMany()
//                   .HasForeignKey(m => m.TransmissionId);
//        }
//    }
//}
