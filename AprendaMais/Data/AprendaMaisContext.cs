using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class AprendaMaisContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aprendamais;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tabela Aluno
            modelBuilder.Entity<Aluno>().
                ToTable("aluno");
            modelBuilder.Entity<Aluno>().
                Property(a => a.nome).
                    HasColumnType("varchar(30)").
                IsRequired();
            modelBuilder.Entity<Aluno>().
                Property(a => a.sexo).
                    HasColumnType("varchar(1)");
            modelBuilder.Entity<Aluno>().
                Property(a => a.DataNascimento).
                    HasColumnName("nascimento").
                    HasColumnType("date").
                IsRequired();
            modelBuilder.Entity<Aluno>().
                Property(a => a.area).
                    HasColumnType("int").
                IsRequired();
            modelBuilder.Entity<Aluno>().
                Property(a => a.Escola).
                    HasColumnName("escola").
                    HasColumnType("varchar(30)").
                IsRequired();
            modelBuilder.Entity<Aluno>().
                Property(a => a.ID_aluno).
                    HasColumnType("int").
                IsRequired();
            modelBuilder.Entity<Aluno>().
                HasKey(a => a.ID_aluno);

            //Avaliação
            modelBuilder.Entity<Avaliacao>().
                ToTable("avaliacao");
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.nota).
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.data).
                    HasColumnName("dia").
                    HasColumnType("date").
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.ID_aluno).
                    HasColumnName("id_aluno").
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                HasKey(a => a.ID_avaliacao);

            //Alternativa Prova
            modelBuilder.Entity<AlternativaProva>().
                ToTable("alternativaprova");
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.ID_AlternativaProva).
                    HasColumnName("id_alternativaprova").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.Resp_correto).
                    HasColumnName("resp_certa").
                    HasColumnType("varchar(1)").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.Texto).
                    HasColumnName("texto").
                    HasColumnType("varchar(max)").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.A).
                    HasColumnType("varchar(max)").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.B).
                    HasColumnType("varchar(max)").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.C).
                    HasColumnType("varchar(max)").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.D).
                    HasColumnType("varchar(max)").
                IsRequired();
            modelBuilder.Entity<AlternativaProva>().
                Property(a => a.E).
                    HasColumnType("varchar(max)");
            modelBuilder.Entity<AlternativaProva>().
                HasKey(a => a.ID_AlternativaProva);
        }
    }
}
