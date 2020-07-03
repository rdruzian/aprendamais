using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class DeConfiguration : IEntityTypeConfiguration<De>
    {
        public void Configure(EntityTypeBuilder<De> builder)
        {
            builder.ToTable("de");

            builder.Property<int>("id_avaliacao").IsRequired();
            builder.Property<int>("id_universidade").IsRequired();

            builder.HasKey("id_avaliacao", "id_universidade");
        }
    }
}
