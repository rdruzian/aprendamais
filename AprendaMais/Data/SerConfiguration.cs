using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class SerConfiguration : IEntityTypeConfiguration<Ser>
    {
        public void Configure(EntityTypeBuilder<Ser> builder)
        {
            builder.
                ToTable("ser");
            builder.
                Property(s => s.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            builder.
                Property(s => s.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                HasKey(s => s.ID_disciplina);
            builder.
                HasKey(s => s.ID_pergunta);
        }
    }
}
