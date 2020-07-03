using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class UniversidadeConfiguration : IEntityTypeConfiguration<Universidade>
    {
        public void Configure(EntityTypeBuilder<Universidade> builder)
        {
            builder.
                ToTable("universidade");
            builder.
                Property(u => u.ID_universidade).
                    HasColumnName("id_universidade").
                IsRequired();
            builder.
                Property(u => u.nome).
                    HasColumnType("varchar(30)").
                IsRequired();
            builder.
                Property(u => u.Estado).
                    HasColumnName("estado").
                    HasColumnType("varchar(2)").
                    HasDefaultValue("SP").
                IsRequired();
            builder.
                HasKey(u => u.ID_universidade);
        }
    }
}
