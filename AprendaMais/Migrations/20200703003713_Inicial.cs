using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AprendaMais.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alternativaprova",
                columns: table => new
                {
                    resp_certa = table.Column<string>(type: "varchar(1)", nullable: false),
                    id_pergunta = table.Column<int>(nullable: false),
                    texto = table.Column<string>(type: "varchar(max)", nullable: false),
                    A = table.Column<string>(type: "varchar(max)", nullable: false),
                    B = table.Column<string>(type: "varchar(max)", nullable: false),
                    C = table.Column<string>(type: "varchar(max)", nullable: false),
                    D = table.Column<string>(type: "varchar(max)", nullable: false),
                    E = table.Column<string>(type: "varchar(max)", nullable: true),
                    id_alternativaprova = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativaprova", x => x.id_alternativaprova);
                });

            migrationBuilder.CreateTable(
                name: "aluno",
                columns: table => new
                {
                    nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sexo = table.Column<string>(type: "varchar(1)", nullable: false),
                    nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    area = table.Column<int>(type: "int", nullable: false),
                    escola = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ID_aluno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluno", x => x.ID_aluno);
                });

            migrationBuilder.CreateTable(
                name: "avaliacao",
                columns: table => new
                {
                    nota = table.Column<int>(nullable: false),
                    id_aluno = table.Column<int>(nullable: false),
                    id_avaliacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dia = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avaliacao", x => x.id_avaliacao);
                });

            migrationBuilder.CreateTable(
                name: "contem",
                columns: table => new
                {
                    id_pergunta = table.Column<int>(nullable: false),
                    id_avaliacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contem", x => x.id_avaliacao);
                    table.UniqueConstraint("AK_contem_id_pergunta", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "de",
                columns: table => new
                {
                    ID_universidade = table.Column<int>(nullable: false),
                    id_avaliacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_de", x => x.id_avaliacao);
                    table.UniqueConstraint("AK_de_ID_universidade", x => x.ID_universidade);
                });

            migrationBuilder.CreateTable(
                name: "disciplina",
                columns: table => new
                {
                    id_disciplina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disciplina", x => x.id_disciplina);
                });

            migrationBuilder.CreateTable(
                name: "ede",
                columns: table => new
                {
                    id_universidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_pergunta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ede", x => x.id_universidade);
                    table.UniqueConstraint("AK_ede_id_pergunta", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "faz",
                columns: table => new
                {
                    id_avaliacao = table.Column<int>(nullable: false),
                    id_aluno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faz", x => x.id_aluno);
                    table.UniqueConstraint("AK_faz_id_avaliacao", x => x.id_avaliacao);
                });

            migrationBuilder.CreateTable(
                name: "pergunta",
                columns: table => new
                {
                    texto_pergunta = table.Column<string>(type: "varchar(max)", nullable: false),
                    id_universidade = table.Column<int>(nullable: false),
                    id_disciplina = table.Column<int>(nullable: false),
                    id_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    figura = table.Column<byte[]>(type: "figure", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pergunta", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "perguntaprova",
                columns: table => new
                {
                    id_prova = table.Column<int>(nullable: false),
                    id_pergunta = table.Column<int>(nullable: false),
                    id_perguntaprova = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perguntaprova", x => x.id_perguntaprova);
                });

            migrationBuilder.CreateTable(
                name: "pertence",
                columns: table => new
                {
                    id_pergunta = table.Column<int>(nullable: false),
                    id_texto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pertence", x => x.id_texto);
                    table.UniqueConstraint("AK_pertence_id_pergunta", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "possui",
                columns: table => new
                {
                    id_perguntaprova = table.Column<int>(nullable: false),
                    id_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_possui", x => x.id_pergunta);
                    table.UniqueConstraint("AK_possui_id_perguntaprova", x => x.id_perguntaprova);
                });

            migrationBuilder.CreateTable(
                name: "ser",
                columns: table => new
                {
                    id_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_disciplina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ser", x => x.id_pergunta);
                    table.UniqueConstraint("AK_ser_id_disciplina", x => x.id_disciplina);
                });

            migrationBuilder.CreateTable(
                name: "texto",
                columns: table => new
                {
                    id_texto = table.Column<int>(nullable: false),
                    id_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    texto = table.Column<string>(type: "varchar(max)", nullable: false),
                    id_disciplina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_texto", x => x.id_pergunta);
                    table.UniqueConstraint("AK_texto_id_disciplina", x => x.id_disciplina);
                    table.UniqueConstraint("AK_texto_id_texto", x => x.id_texto);
                });

            migrationBuilder.CreateTable(
                name: "universidade",
                columns: table => new
                {
                    id_universidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, defaultValue: "SP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universidade", x => x.id_universidade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternativaprova");

            migrationBuilder.DropTable(
                name: "aluno");

            migrationBuilder.DropTable(
                name: "avaliacao");

            migrationBuilder.DropTable(
                name: "contem");

            migrationBuilder.DropTable(
                name: "de");

            migrationBuilder.DropTable(
                name: "disciplina");

            migrationBuilder.DropTable(
                name: "ede");

            migrationBuilder.DropTable(
                name: "faz");

            migrationBuilder.DropTable(
                name: "pergunta");

            migrationBuilder.DropTable(
                name: "perguntaprova");

            migrationBuilder.DropTable(
                name: "pertence");

            migrationBuilder.DropTable(
                name: "possui");

            migrationBuilder.DropTable(
                name: "ser");

            migrationBuilder.DropTable(
                name: "texto");

            migrationBuilder.DropTable(
                name: "universidade");
        }
    }
}
