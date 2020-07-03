using Microsoft.EntityFrameworkCore;
using System;
using AprendaMais.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class AlternativaProvaConfiguration : IEntityTypeConfiguration<AlternativaProva>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AlternativaProva> builder)
        {
            builder.
                ToTable("alternativaprova");
            builder.
                Property(a => a.ID_AlternativaProva).
                    HasColumnName("id_alternativaprova").
                IsRequired();
            builder.
                Property(a => a.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                Property(a => a.Resp_correto).
                    HasColumnName("resp_certa").
                    HasColumnType("varchar(1)").
                IsRequired();
            builder.
                Property(a => a.Texto).
                    HasColumnName("texto").
                    HasColumnType("text").
                IsRequired();
            builder.
                Property(a => a.A).
                    HasColumnType("varchar(max)").
                IsRequired();
            builder.
                Property(a => a.B).
                    HasColumnType("varchar(max)").
                IsRequired();
            builder.
                Property(a => a.C).
                    HasColumnType("varchar(max)").
                IsRequired();
            builder.
                Property(a => a.D).
                    HasColumnType("varchar(max)").
                IsRequired();
            builder.
                Property(a => a.E).
                    HasColumnType("varchar(max)");
            builder.
                HasKey(a => a.ID_AlternativaProva);
        }
    }
}
