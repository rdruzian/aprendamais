using AprendaMais.Model;
using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;

namespace AprendaMais.Data
{
    public class AprendaMaisContext : DbContext
    {
        //Tabelas
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<AlternativaPergunta> AlternativaPergunta { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Pergunta> Pergunta { get; set; }
        public DbSet<Texto> Texto { get; set; }
        public DbSet<Universidade> Universidade { get; set; }
        public DbSet<Dissertativa> Dissertativa { get; set; }
        public DbSet<AlternativaPergunta> AlternativaPerguntas { get; set; }

        //Tabelas de ligações
        public DbSet<AvaliacaoAluno> AvaliacaoAluno { get; set; }
        public DbSet<AvaliacaoPergunta> AvaliacaoPergunta { get; set; }
        public DbSet<PerguntaDisciplina> PerguntaDisciplina { get; set; }

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
