using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class PossuiConfiguration : IEntityTypeConfiguration<Possui>
    {
        public void Configure(EntityTypeBuilder<Possui> builder)
        {
            builder.ToTable("possui");

            builder.Property<int>("id_pergunta").IsRequired();
            builder.Property<int>("id_perguntaprova").IsRequired();

            builder.HasKey("id_pergunta", "id_perguntaprova");
        }
    }
}
