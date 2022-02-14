using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryCrea.Data.Migrations
{
    public partial class migrationsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CadastroCategoria",
                columns: new[] { "Id", "Ativo", "CreateAt", "Name", "UpdateAt" },
                values: new object[] { new Guid("f14a5b01-4d1c-40c9-817c-c86f52933498"), true, new DateTime(2022, 2, 14, 14, 28, 8, 761, DateTimeKind.Utc).AddTicks(6295), "Terror", null });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "Ativo", "CPF", "CreateAt", "Matricula", "Nome", "RG", "UpdateAt", "tipo" },
                values: new object[] { new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"), true, "000000000000", new DateTime(2022, 2, 14, 10, 28, 8, 761, DateTimeKind.Local).AddTicks(6621), "0000000000", "João", 11111111, null, 0 });

            migrationBuilder.InsertData(
                table: "CadastroLivro",
                columns: new[] { "Id", "Ano", "AutorId", "CategoriaId", "CreateAt", "Edicao", "Editora", "ISBN", "Titulo", "UpdateAt", "situacao" },
                values: new object[] { new Guid("7f3cf61a-fc9a-4840-bd6c-94e48a9884f9"), new DateTime(2022, 2, 14, 10, 28, 8, 761, DateTimeKind.Local).AddTicks(6550), new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"), new Guid("f14a5b01-4d1c-40c9-817c-c86f52933498"), new DateTime(2022, 2, 14, 10, 28, 8, 761, DateTimeKind.Local).AddTicks(6563), "Feira de São Paulo", "Abril", "123456789", "Zumbies", null, 0 });

            migrationBuilder.InsertData(
                table: "Movimentacao",
                columns: new[] { "Id", "CreateAt", "Devolucao", "LivroId", "MaxDevolucacao", "PessoaEmprestimoId", "PessoaResponsavelId", "UpdateAt", "situacaoEmprestimo" },
                values: new object[] { new Guid("1fe1b8b3-b830-4503-b7ce-322613829359"), new DateTime(2022, 2, 14, 10, 28, 8, 761, DateTimeKind.Local).AddTicks(6604), new DateTime(2022, 2, 14, 10, 28, 8, 761, DateTimeKind.Local).AddTicks(6600), new Guid("7f3cf61a-fc9a-4840-bd6c-94e48a9884f9"), new DateTime(2022, 2, 14, 10, 28, 8, 761, DateTimeKind.Local).AddTicks(6602), new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"), new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"), null, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movimentacao",
                keyColumn: "Id",
                keyValue: new Guid("1fe1b8b3-b830-4503-b7ce-322613829359"));

            migrationBuilder.DeleteData(
                table: "CadastroLivro",
                keyColumn: "Id",
                keyValue: new Guid("7f3cf61a-fc9a-4840-bd6c-94e48a9884f9"));

            migrationBuilder.DeleteData(
                table: "CadastroCategoria",
                keyColumn: "Id",
                keyValue: new Guid("f14a5b01-4d1c-40c9-817c-c86f52933498"));

            migrationBuilder.DeleteData(
                table: "Pessoa",
                keyColumn: "Id",
                keyValue: new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"));
        }
    }
}
