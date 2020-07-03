using AprendaMais.Model;
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
            //Aluno
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());

            //Avaliação
            modelBuilder.ApplyConfiguration(new AvaliacaoConfiguration());

            //Alternativa Prova
            modelBuilder.ApplyConfiguration(new AlternativaProvaConfiguration());

            //Contem
            modelBuilder.ApplyConfiguration(new ContemConfiguratioon());

            //De
            modelBuilder.ApplyConfiguration(new DeConfiguration());

            //Disciplina
            modelBuilder.ApplyConfiguration(new DisciplinaConfiguration());

            //Ede
            modelBuilder.ApplyConfiguration(new EdeConfiguration());

            //Faz
            modelBuilder.ApplyConfiguration(new FazConfiguration());

            //Pergunta
            modelBuilder.ApplyConfiguration(new PerguntaConfiguration());

            //PerguntaProva
            modelBuilder.ApplyConfiguration(new PerguntaProvaConfiguration());

            //Pertence
            modelBuilder.ApplyConfiguration(new PertenceConfiguration());

            //Possui
            modelBuilder.ApplyConfiguration(new PossuiConfiguration());

            //Ser
            modelBuilder.ApplyConfiguration(new SerConfiguration());

            //Texto
            modelBuilder.ApplyConfiguration(new TextoConfiguration());

            //Universidade
            modelBuilder.ApplyConfiguration(new UniversidadeConfiguration());
        }
    }
}
