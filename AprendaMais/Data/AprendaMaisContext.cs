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

            //Avalicao
            modelBuilder.Entity<Avaliacao>().
                ToTable("avaliacao");
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.ID_aluno).
                    HasColumnName("id_aluno").
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                Property(a => a.data).
                    HasColumnName("dia").
                    HasColumnType("date").
                IsRequired();
            modelBuilder.Entity<Avaliacao>().
                HasKey(a => a.ID_avaliacao);

            //Contem
            modelBuilder.Entity<Contem>().
                ToTable("contem");
            modelBuilder.Entity<Contem>().
                Property(c => c.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            modelBuilder.Entity<Contem>().
                Property(c => c.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Contem>().
                HasKey(c => c.ID_pergunta);
            modelBuilder.Entity<Contem>().
                HasKey(c => c.ID_avaliacao);

            //De
            modelBuilder.Entity<De>().
                ToTable("de");
            modelBuilder.Entity<De>().
                Property(c => c.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            modelBuilder.Entity<De>().
                Property(c => c.ID_universidade).
                    HasColumnName("ID_universidade").
                IsRequired();
            modelBuilder.Entity<De>().
                HasKey(c => c.ID_universidade);
            modelBuilder.Entity<De>().
                HasKey(c => c.ID_avaliacao);

            //Disciplina
            modelBuilder.Entity<Disciplina>().
                ToTable("disciplina");
            modelBuilder.Entity<Disciplina>().
                Property(d => d.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            modelBuilder.Entity<Disciplina>().
                Property(d => d.nome).
                    HasColumnType("varchar(10)").
                IsRequired();
            modelBuilder.Entity<Disciplina>().
                HasKey(d => d.ID_disciplina);

            //Ede
            modelBuilder.Entity<Ede>().
                ToTable("ede");
            modelBuilder.Entity<Ede>().
                Property(d => d.ID_universidade).
                    HasColumnName("id_universidade").
                IsRequired();
            modelBuilder.Entity<Ede>().
                Property(d => d.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Ede>().
                HasKey(d => d.ID_pergunta);
            modelBuilder.Entity<Ede>().
                HasKey(d => d.ID_universidade);

            //Faz
            modelBuilder.Entity<Faz>().
                ToTable("faz");
            modelBuilder.Entity<Faz>().
                Property(d => d.ID_avaliacao).
                    HasColumnName("id_avaliacao").
                IsRequired();
            modelBuilder.Entity<Faz>().
                Property(d => d.ID_aluno).
                    HasColumnName("id_aluno").
                IsRequired();
            modelBuilder.Entity<Faz>().
                HasKey(d => d.ID_avaliacao);
            modelBuilder.Entity<Faz>().
                HasKey(d => d.ID_aluno);

            //Pergunta
            modelBuilder.Entity<Pergunta>().
                ToTable("pergunta");
            modelBuilder.Entity<Pergunta>().
                Property(d => d.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            modelBuilder.Entity<Pergunta>().
                Property(d => d.ID_universidade).
                    HasColumnName("id_universidade").
                IsRequired();
            modelBuilder.Entity<Pergunta>().
                Property(d => d.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Pergunta>().
                Property(d => d.texto_pergunta).
                    HasColumnType("varchar(max)").
                IsRequired();
            modelBuilder.Entity<Pergunta>().
                Property(d => d.Figura).
                    HasColumnName("figura").
                    HasColumnType("figure");
            modelBuilder.Entity<Pergunta>().
                HasKey(d => d.ID_pergunta);

            //PerguntaProva
            modelBuilder.Entity<PerguntaProva>().
                ToTable("perguntaprova");
            modelBuilder.Entity<PerguntaProva>().
                Property(d => d.ID_prova).
                    HasColumnName("id_prova").
                IsRequired();
            modelBuilder.Entity<PerguntaProva>().
                Property(d => d.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<PerguntaProva>().
                Property(d => d.ID_perguntaProva).
                    HasColumnName("id_perguntaprova").
                IsRequired();
            modelBuilder.Entity<PerguntaProva>().
                HasKey(d => d.ID_perguntaProva);

            //Pertence
            modelBuilder.Entity<Pertence>().
                ToTable("pertence");
            modelBuilder.Entity<Pertence>().
                Property(p => p.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Pertence>().
                Property(p => p.ID_texto).
                    HasColumnName("id_texto").
                IsRequired();
            modelBuilder.Entity<Pertence>().
                HasKey(p => p.ID_pergunta);
            modelBuilder.Entity<Pertence>().
                HasKey(p => p.ID_texto);

            //Possui
            modelBuilder.Entity<Possui>().
                ToTable("possui");
            modelBuilder.Entity<Possui>().
                Property(p => p.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Possui>().
                Property(p => p.ID_perguntaProva).
                    HasColumnName("id_perguntaprova").
                IsRequired();
            modelBuilder.Entity<Possui>().
                HasKey(p => p.ID_perguntaProva);
            modelBuilder.Entity<Possui>().
                HasKey(p => p.ID_pergunta);

            //Ser
            modelBuilder.Entity<Ser>().
                ToTable("ser");
            modelBuilder.Entity<Ser>().
                Property(s => s.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            modelBuilder.Entity<Ser>().
                Property(s => s.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Ser>().
                HasKey(s => s.ID_disciplina);
            modelBuilder.Entity<Ser>().
                HasKey(s => s.ID_pergunta);

            //Texto
            modelBuilder.Entity<Texto>().
                ToTable("texto");
            modelBuilder.Entity<Texto>().
                Property(t => t.Enunciado).
                    HasColumnName("texto").
                    HasColumnType("varchar(max)").
                IsRequired();

            modelBuilder.Entity<Texto>().
                Property(t => t.ID_texto).
                    HasColumnName("id_texto").
                IsRequired();
            modelBuilder.Entity<Texto>().
                Property(t => t.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            modelBuilder.Entity<Texto>().
                Property(t => t.ID_disciplina).
                    HasColumnName("id_disciplina").
                IsRequired();
            modelBuilder.Entity<Texto>().
                HasKey(t => t.ID_texto);
            modelBuilder.Entity<Texto>().
                HasKey(t => t.ID_disciplina);
            modelBuilder.Entity<Texto>().
                HasKey(t => t.ID_pergunta);

            //Universidade
            modelBuilder.Entity<Universidade>().
                ToTable("universidade");
            modelBuilder.Entity<Universidade>().
                Property(u => u.ID_universidade).
                    HasColumnName("id_universidade").
                IsRequired();
            modelBuilder.Entity<Universidade>().
                Property(u => u.nome).
                    HasColumnType("varchar(30)").
                IsRequired();
            modelBuilder.Entity<Universidade>().
                Property(u => u.Estado).
                    HasColumnName("estado").
                    HasColumnType("varchar(2)").
                    HasDefaultValue("SP").
                IsRequired();
            modelBuilder.Entity<Universidade>().
                HasKey(u => u.ID_universidade);
        }
    }
}
