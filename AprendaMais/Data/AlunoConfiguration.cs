using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Aluno> builder)
        {
            //Tabela Aluno
            builder.ToTable("aluno");

            builder.Property(a => a.nome).
                    HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.sexo).HasColumnType("varchar(1)");
            builder.Property(a => a.DataNascimento).
                    HasColumnName("nascimento").HasColumnType("date").IsRequired();
            builder.Property(a => a.area).HasColumnType("int").IsRequired();
            builder.Property(a => a.escola).HasColumnName("escola").
                    HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.ID_aluno).HasColumnType("int").IsRequired();

            builder.HasKey(a => a.ID_aluno);
        }
    }
}
