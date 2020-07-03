using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class PerguntaProvaConfiguration : IEntityTypeConfiguration<PerguntaProva>
    {
        public void Configure(EntityTypeBuilder<PerguntaProva> builder)
        {
            builder.ToTable("perguntaprova");

            builder.Property<int>("id_prova").IsRequired();
            builder.Property<int>("id_pergunta").IsRequired();
            builder.Property<int>("id_perguntaprova").IsRequired();
            builder.HasKey("id_aluno", "id_pergunta", "id_perguntaprova");
        }
    }
}
