using AprendaMais.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class DissertativaConfiguration : IEntityTypeConfiguration<Dissertativa>
    {
        public void Configure(EntityTypeBuilder<Dissertativa> builder)
        {
            builder.ToTable("dissertativa");

            builder.Property(d => d.ID_dissertativa).HasColumnName("id_dissertativa").IsRequired();
            builder.Property(d => d.ID_pergunta).HasColumnName("id_pergunta").IsRequired();
            builder.Property(d => d.Resp_Aluno).HasColumnType("text").HasColumnName("resp_aluno");
            builder.Property(d => d.gabarito1).HasColumnType("text").HasColumnName("gabarito1").IsRequired();
            builder.Property(d => d.gabarito2).HasColumnType("text").HasColumnName("gabarito2").IsRequired();
            builder.Property(d => d.gabarito3).HasColumnType("text").HasColumnName("gabarito3").IsRequired();

            builder.HasKey(d => d.ID_dissertativa);
            builder.HasKey(d => d.ID_pergunta);
        }
    }
}
