using AprendaMais.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class TextoConfiguration : IEntityTypeConfiguration<Texto>
    {
        public void Configure(EntityTypeBuilder<Texto> builder)
        {
            builder.
                ToTable("texto");
            builder.
                Property(t => t.Enunciado).
                    HasColumnName("texto").
                    HasColumnType("text").
                IsRequired();

            builder.
                Property(t => t.ID_texto).
                    HasColumnName("id_texto").
                IsRequired();
            builder.
                Property(t => t.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                Property(t => t.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            builder.
                HasKey(t => t.ID_texto);
            builder.
                HasKey(t => t.ID_disciplina);
            builder.
                HasKey(t => t.ID_pergunta);
        }
    }
}
