using System;
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
                    id_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_alternativaprova = table.Column<int>(nullable: false),
                    resp_certa = table.Column<string>(type: "varchar(1)", nullable: false),
                    A = table.Column<string>(type: "varchar(max)", nullable: false),
                    B = table.Column<string>(type: "varchar(max)", nullable: false),
                    C = table.Column<string>(type: "varchar(max)", nullable: false),
                    D = table.Column<string>(type: "varchar(max)", nullable: false),
                    E = table.Column<string>(type: "varchar(max)", nullable: true),
                    figura_A = table.Column<byte[]>(type: "figure", nullable: true),
                    figura_B = table.Column<byte[]>(type: "figure", nullable: true),
                    figura_C = table.Column<byte[]>(type: "figure", nullable: true),
                    figura_D = table.Column<byte[]>(type: "figure", nullable: true),
                    figura_E = table.Column<byte[]>(type: "figure", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativaprova", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "aluno",
                columns: table => new
                {
                    ID_aluno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sexo = table.Column<string>(type: "varchar(1)", nullable: false),
                    nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    area = table.Column<int>(type: "int", nullable: false),
                    escola = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluno", x => x.ID_aluno);
                });

            migrationBuilder.CreateTable(
                name: "avaliacao",
                columns: table => new
                {
                    id_aluno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nota = table.Column<int>(nullable: false),
                    id_avaliacao = table.Column<int>(nullable: false),
                    id_pergunta = table.Column<int>(nullable: false),
                    dia = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avaliacao", x => x.id_aluno);
                });

            migrationBuilder.CreateTable(
                name: "disciplina",
                columns: table => new
                {
                    id_disciplina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disciplina", x => x.id_disciplina);
                });

            migrationBuilder.CreateTable(
                name: "Dissertativa",
                columns: table => new
                {
                    ID_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resp_Aluno = table.Column<string>(nullable: true),
                    gabarito1 = table.Column<string>(nullable: false),
                    gabarito2 = table.Column<string>(nullable: false),
                    gabarito3 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dissertativa", x => x.ID_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "pergunta",
                columns: table => new
                {
                    id_disciplina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enunciado = table.Column<string>(type: "text", nullable: false),
                    id_universidade = table.Column<int>(nullable: false),
                    id_pergunta = table.Column<int>(nullable: false),
                    figura = table.Column<byte[]>(type: "figure", nullable: true),
                    dissertativa = table.Column<bool>(type: "bool", nullable: false, defaultValueSql: "false"),
                    id_alternativa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pergunta", x => x.id_disciplina);
                });

            migrationBuilder.CreateTable(
                name: "texto",
                columns: table => new
                {
                    id_pergunta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_texto = table.Column<int>(nullable: false),
                    texto = table.Column<string>(type: "text", nullable: false),
                    id_disciplina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_texto", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "universidade",
                columns: table => new
                {
                    id_universidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, defaultValue: "SP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universidade", x => x.id_universidade);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacaoAluno",
                columns: table => new
                {
                    AvaliacaoAlunoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvaliacaoID_aluno = table.Column<int>(nullable: false),
                    AlunoID_aluno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoAluno", x => x.AvaliacaoAlunoID);
                    table.ForeignKey(
                        name: "FK_AvaliacaoAluno_aluno_AlunoID_aluno",
                        column: x => x.AlunoID_aluno,
                        principalTable: "aluno",
                        principalColumn: "ID_aluno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvaliacaoAluno_avaliacao_AvaliacaoID_aluno",
                        column: x => x.AvaliacaoID_aluno,
                        principalTable: "avaliacao",
                        principalColumn: "id_aluno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacaoPergunta",
                columns: table => new
                {
                    AvaliacaoPerguntaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvaliacaoID_aluno = table.Column<int>(nullable: true),
                    PerguntaID_disciplina = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoPergunta", x => x.AvaliacaoPerguntaID);
                    table.ForeignKey(
                        name: "FK_AvaliacaoPergunta_avaliacao_AvaliacaoID_aluno",
                        column: x => x.AvaliacaoID_aluno,
                        principalTable: "avaliacao",
                        principalColumn: "id_aluno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvaliacaoPergunta_pergunta_PerguntaID_disciplina",
                        column: x => x.PerguntaID_disciplina,
                        principalTable: "pergunta",
                        principalColumn: "id_disciplina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerguntaDisciplina",
                columns: table => new
                {
                    PerguntaDisciplinaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerguntaID_disciplina = table.Column<int>(nullable: true),
                    DisciplinaID_disciplina = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaDisciplina", x => x.PerguntaDisciplinaID);
                    table.ForeignKey(
                        name: "FK_PerguntaDisciplina_disciplina_DisciplinaID_disciplina",
                        column: x => x.DisciplinaID_disciplina,
                        principalTable: "disciplina",
                        principalColumn: "id_disciplina",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerguntaDisciplina_pergunta_PerguntaID_disciplina",
                        column: x => x.PerguntaID_disciplina,
                        principalTable: "pergunta",
                        principalColumn: "id_disciplina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoAluno_AlunoID_aluno",
                table: "AvaliacaoAluno",
                column: "AlunoID_aluno");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoAluno_AvaliacaoID_aluno",
                table: "AvaliacaoAluno",
                column: "AvaliacaoID_aluno");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoPergunta_AvaliacaoID_aluno",
                table: "AvaliacaoPergunta",
                column: "AvaliacaoID_aluno");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoPergunta_PerguntaID_disciplina",
                table: "AvaliacaoPergunta",
                column: "PerguntaID_disciplina");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaDisciplina_DisciplinaID_disciplina",
                table: "PerguntaDisciplina",
                column: "DisciplinaID_disciplina");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaDisciplina_PerguntaID_disciplina",
                table: "PerguntaDisciplina",
                column: "PerguntaID_disciplina");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternativaprova");

            migrationBuilder.DropTable(
                name: "AvaliacaoAluno");

            migrationBuilder.DropTable(
                name: "AvaliacaoPergunta");

            migrationBuilder.DropTable(
                name: "Dissertativa");

            migrationBuilder.DropTable(
                name: "PerguntaDisciplina");

            migrationBuilder.DropTable(
                name: "texto");

            migrationBuilder.DropTable(
                name: "universidade");

            migrationBuilder.DropTable(
                name: "aluno");

            migrationBuilder.DropTable(
                name: "avaliacao");

            migrationBuilder.DropTable(
                name: "disciplina");

            migrationBuilder.DropTable(
                name: "pergunta");
        }
    }
}
