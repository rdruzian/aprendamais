using AprendaMais.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class AvaliacaoPerguntaConfiguration : IEntityTypeConfiguration<AvaliacaoPergunta>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoPergunta> builder)
        {
            builder.ToTable("avaliacao_pergunta");

            builder.Property(ap => ap.AvaliacaoPerguntaID).HasColumnName("avaliacao_perguntaID").IsRequired();
            builder.Property<int>("avalicaoID");
            builder.Property<int>("perguntaID");

            builder.HasKey("avaliacao_perguntaID", "avalicaoID", "perguntaID");

            builder.HasOne(ap => ap.Avaliacao).WithMany(p => p.Perguntas).HasForeignKey("avaliacaoID");
            builder.HasOne(ap => ap.Pergunta).WithMany(a => a.Avaliacoes).HasForeignKey("avaliacaoID");
        }
    }
}
