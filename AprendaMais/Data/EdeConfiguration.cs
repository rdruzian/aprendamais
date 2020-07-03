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
            builder.
                ToTable("ede");
            builder.
                Property(d => d.ID_universidade).
                    HasColumnName("id_universidade").
                IsRequired();
            builder.
                Property(d => d.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                HasKey(d => d.ID_pergunta);
            builder.
                HasKey(d => d.ID_universidade);
        }
    }
}
