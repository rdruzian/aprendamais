using AprendaMais.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class PertenceConfiguration : IEntityTypeConfiguration<Pertence>
    {
        public void Configure(EntityTypeBuilder<Pertence> builder)
        {
            builder.ToTable("pertence");

            builder.Property<int>("id_pergunta").IsRequired();
            builder.Property<int>("id_texto").IsRequired();
            
            builder.HasKey("id_pergunta", "id_texto");
        }
    }
}
