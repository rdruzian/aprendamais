using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class FazConfiguration : IEntityTypeConfiguration<Faz>
    {
        public void Configure(EntityTypeBuilder<Faz> builder)
        {
            builder.ToTable("faz");
            //Shadow properties
            builder.Property<int>("id_avaliacao").IsRequired();
            builder.Property<int>("id_aluno").IsRequired();
            //Chaves
            builder.HasKey("id_avaliacao", "id_aluno");
        }
    }
}
