using Microsoft.EntityFrameworkCore;
using System;
using AprendaMais.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AprendaMais.Model;

namespace AprendaMais.Data
{
    public class AlternativaPerguntaConfiguration : IEntityTypeConfiguration<AlternativaPergunta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AlternativaPergunta> builder)
        {
            builder.ToTable("alternativaprova");

            builder.
                Property(a => a.ID_alternativa).
                    HasColumnName("id_alternativaprova").IsRequired();
            builder.
                Property(a => a.ID_pergunta).
                    HasColumnName("id_pergunta").IsRequired();
            builder.
                Property(a => a.Resp_correto).
                    HasColumnName("resp_certa").
                    HasColumnType("varchar(1)").IsRequired();
            builder.
                Property(a => a.A).
                    HasColumnType("varchar(max)").IsRequired();
            builder.
                Property(a => a.B).
                    HasColumnType("varchar(max)").IsRequired();
            builder.
                Property(a => a.C).
                    HasColumnType("varchar(max)").IsRequired();
            builder.
                Property(a => a.D).
                    HasColumnType("varchar(max)").IsRequired();
            builder.
                Property(a => a.E).HasColumnType("varchar(max)");

            builder.Property(a => a.figura_A).HasColumnType("figure");
            builder.Property(a => a.figura_B).HasColumnType("figure");
            builder.Property(a => a.figura_C).HasColumnType("figure");
            builder.Property(a => a.figura_D).HasColumnType("figure");
            builder.Property(a => a.figura_E).HasColumnType("figure");

            builder.HasKey(a => a.ID_alternativa);

            builder.HasKey(a => a.ID_pergunta);
        }
    }
}
