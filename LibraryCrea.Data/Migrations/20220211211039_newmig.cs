using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryCrea.Data.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroCategoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadastroLivro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<DateTime>(type: "datetime2", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false),
                    AutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroLivro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadastroLivro_CadastroCategoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CadastroCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CadastroLivro_Pessoa_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DadosParaContato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tel = table.Column<int>(type: "int", nullable: false),
                    tipoTel = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosParaContato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadosParaContato_Pessoa_PessoaEntityId",
                        column: x => x.PessoaEntityId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Movimentacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LivroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaEmprestimoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaResponsavelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxDevolucacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Devolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    situacaoEmprestimo = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentacao_CadastroLivro_LivroId",
                        column: x => x.LivroId,
                        principalTable: "CadastroLivro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadastroLivro_AutorId",
                table: "CadastroLivro",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroLivro_CategoriaId",
                table: "CadastroLivro",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroLivro_ISBN",
                table: "CadastroLivro",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DadosParaContato_PessoaEntityId",
                table: "DadosParaContato",
                column: "PessoaEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_LivroId",
                table: "Movimentacao",
                column: "LivroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosParaContato");

            migrationBuilder.DropTable(
                name: "Movimentacao");

            migrationBuilder.DropTable(
                name: "CadastroLivro");

            migrationBuilder.DropTable(
                name: "CadastroCategoria");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
