using AprendaMais.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class AvaliacaoAlunoConfiguration : IEntityTypeConfiguration<AvaliacaoAluno>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoAluno> builder)
        {
            builder.ToTable("avaliacao_aluno");

            builder.Property(aa => aa.AvaliacaoAlunoID).HasColumnName("avaliacao_alunoID").IsRequired();
            builder.Property<int>("avaliacaoID");
            builder.Property<int>("alunoID");

            builder.HasKey("avaliacao_alunoID","avaliacaoID", "alunoID");

            builder.HasOne(aa => aa.Avaliacao).WithMany(a => a.Alunos).HasForeignKey("avaliacaoID");
            builder.HasOne(aa => aa.Aluno).WithMany(a => a.Avaliacoes).HasForeignKey("alunoID");
        }
    }
}
