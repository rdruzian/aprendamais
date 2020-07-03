using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class FazConfiguration : IEntityTypeConfiguration<Faz>
    {
        public void Configure(EntityTypeBuilder<Faz> builder)
        {
            builder.
                ToTable("faz");
            builder.
                Property(d => d.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            builder.
                Property(d => d.ID_aluno).
                    HasColumnName("id_aluno").
                IsRequired();
            builder.
                HasKey(d => d.ID_avaliacao);
            builder.
                HasKey(d => d.ID_aluno);
        }
    }
}
