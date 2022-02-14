using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Seeds
{
    public class CadastroLivroSeeds
    {
        public static void CadastroLivro(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadastroLivroEntity>().HasData(

            new CadastroLivroEntity()
            {
                Id = new Guid("7f3cf61a-fc9a-4840-bd6c-94e48a9884f9"),
                Ano = DateTime.Now,
                Edicao = "Feira de São Paulo",
                ISBN = "123456789",
                Editora = "Abril",
                situacao = CadastroLivroEntity.Situacao.Disponivel,
                Titulo = "Zumbies",
                CategoriaId = new Guid("f14a5b01-4d1c-40c9-817c-c86f52933498"),
                AutorId = new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"),
                CreateAt = DateTime.Now
            }
            );
        }
    }
}
