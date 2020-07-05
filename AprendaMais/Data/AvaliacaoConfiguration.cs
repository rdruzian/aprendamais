using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class AvaliacaoConfiguration : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("avaliacao");
            
            builder.Property(a => a.nota).IsRequired();
            builder.Property(a => a.data).HasColumnName("dia").HasColumnType("date").IsRequired();
            builder.Property(a => a.ID_avaliacao).HasColumnName("id_avaliacao").IsRequired();
            builder.Property(a => a.ID_aluno).HasColumnName("id_aluno").IsRequired();
            builder.Property(a => a.ID_pergunta).HasColumnName("id_pergunta").IsRequired();
            
            builder.HasKey(a => a.ID_avaliacao);
            builder.HasKey(a => a.ID_pergunta);
            builder.HasKey(a => a.ID_aluno);
        }
    }
}
