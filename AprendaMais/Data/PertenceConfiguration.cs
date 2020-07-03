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
            builder.
                ToTable("pertence");
            builder.
                Property(p => p.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                Property(p => p.ID_texto).
                    HasColumnName("id_texto").
                IsRequired();
            builder.
                HasKey(p => p.ID_pergunta);
            builder.
                HasKey(p => p.ID_texto);
        }
    }
}
