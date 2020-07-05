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
        //Tabelas
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlternativaPergunta> AlternativaPergunta { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Texto> Textos { get; set; }
        public DbSet<Universidade> Universidades { get; set; }

        //Tabelas de ligações

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

            //Alternativa Pergunta
            modelBuilder.ApplyConfiguration(new AlternativaPerguntaConfiguration());

            //Disciplina
            modelBuilder.ApplyConfiguration(new DisciplinaConfiguration());

            //Pergunta
            modelBuilder.ApplyConfiguration(new PerguntaConfiguration());

            //Texto
            modelBuilder.ApplyConfiguration(new TextoConfiguration());

            //Universidade
            modelBuilder.ApplyConfiguration(new UniversidadeConfiguration());
        }
    }
}
