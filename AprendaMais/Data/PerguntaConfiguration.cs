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
            builder.ToTable("pergunta");
            
            builder.Property(d => d.ID_disciplina).HasColumnName("id_disciplina").IsRequired();
            builder.Property(d => d.ID_universidade).HasColumnName("id_universidade");
            builder.Property(d => d.ID_pergunta).HasColumnName("id_pergunta").IsRequired();
            builder.Property(d => d.enunciado).HasColumnType("text").IsRequired();
            builder.Property(d => d.Figura).HasColumnName("figura").HasColumnType("figure");
            builder.Property(d => d.dissertativa).HasColumnType("bool").HasDefaultValueSql("false").IsRequired();
            builder.Property(d => d.ID_alternativa).HasColumnName("id_alternativa").IsRequired();
            
            builder.HasKey(d => d.ID_pergunta);
            builder.HasKey(d => d.ID_universidade);
            builder.HasKey(d => d.ID_alternativa);
            builder.HasKey(d => d.ID_disciplina);
        }
    }
}
