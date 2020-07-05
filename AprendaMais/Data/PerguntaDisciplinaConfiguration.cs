using AprendaMais.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class PerguntaDisciplinaConfiguration : IEntityTypeConfiguration<PerguntaDisciplina>
    {
        public void Configure(EntityTypeBuilder<PerguntaDisciplina> builder)
        {
            builder.ToTable("pergunta_disciplina");

            builder.Property<int>("perguntaID");
            builder.Property<int>("disciplinaID");

            builder.HasKey("perguntaID", "disciplinaID");

            builder.HasOne(pd => pd.Pergunta).WithMany(p => p.Disciplinas).HasForeignKey("perguntaID");
            builder.HasOne(pd => pd.Disciplina).WithMany(d => d.Perguntas).HasForeignKey("disciplinaID");
        }
    }
}
