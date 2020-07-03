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
            builder.
                ToTable("de");
            builder.
                Property(c => c.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            builder.
                Property(c => c.ID_universidade).
                    HasColumnName("ID_universidade").
                IsRequired();
            builder.
                HasKey(c => c.ID_universidade);
            builder.
                HasKey(c => c.ID_avaliacao);
        }
    }
}
