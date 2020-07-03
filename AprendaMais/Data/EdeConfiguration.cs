using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class EdeConfiguration : IEntityTypeConfiguration<Ede>
    {
        public void Configure(EntityTypeBuilder<Ede> builder)
        {
            builder.ToTable("ede");

            builder.Property<int>("id_universidade").IsRequired();
            builder.Property<int>("id_pergunta").IsRequired();

            builder.HasKey("id_universidade", "id_pergunta");
        }
    }
}
