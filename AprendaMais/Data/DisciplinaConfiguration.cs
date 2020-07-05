using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class DisciplinaConfiguration : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.ToTable("disciplina");

            builder.Property(d => d.ID_disciplina).HasColumnName("id_disciplina").IsRequired();
            builder.Property(d => d.nome).HasColumnType("varchar(10)").IsRequired();
            
            builder.HasKey(d => d.ID_disciplina);
        }
    }
}
