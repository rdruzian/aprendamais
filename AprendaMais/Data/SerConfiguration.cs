using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class SerConfiguration : IEntityTypeConfiguration<Ser>
    {
        public void Configure(EntityTypeBuilder<Ser> builder)
        {
            builder.ToTable("ser");

            builder.Property<int>("id_disciplina").IsRequired();
            builder.Property<int>("id_pergunta").IsRequired();

            builder. HasKey("id_disciplina", "id_pergunta");
        }
    }
}
