using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class ContemConfiguratioon : IEntityTypeConfiguration<Contem>
    {
        public void Configure(EntityTypeBuilder<Contem> builder)
        {
            builder.ToTable("contem");

            builder.Property<int>("id_avaliacao").IsRequired();
            builder.Property<int>("id_pergunta").IsRequired();

            builder.HasKey("id_avaliacao", "id_pergunta");
        }
    }
}
