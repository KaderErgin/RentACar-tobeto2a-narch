﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;
public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(i => i.Id);
        builder.ToTable("Cars");
    }
}
//using Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//public class CarConfiguration : IEntityTypeConfiguration<Car>
//{
//    public void Configure(EntityTypeBuilder<Car> builder)
//    {
//        builder.HasKey(i => i.Id);
//        builder.ToTable("Cars");

//        // Car - Model ilişkisini belirt
//        builder.HasOne<Car>()
//               .WithMany()
//               .HasForeignKey(c => c.ModelId);
//    }
//}