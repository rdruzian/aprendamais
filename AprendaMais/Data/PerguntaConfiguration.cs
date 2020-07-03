using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class PerguntaConfiguration : IEntityTypeConfiguration<Pergunta>
    {
        public void Configure(EntityTypeBuilder<Pergunta> builder)
        {
            builder.
                ToTable("pergunta");
            builder.
                Property(d => d.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            builder.
                Property(d => d.ID_universidade).
                    HasColumnName("id_universidade").
                IsRequired();
            builder.
                Property(d => d.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                Property(d => d.texto_pergunta).
                    HasColumnType("text").
                IsRequired();
            builder.
                Property(d => d.Figura).
                    HasColumnName("figura").
                    HasColumnType("figure");
            builder.
                HasKey(d => d.ID_pergunta);
        }
    }
}
