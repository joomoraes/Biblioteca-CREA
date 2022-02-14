using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Seeds
{
    public static class CadastroCategoriaSeeds
    {
        public static void CadastroCategoria(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadastroCategoriaEntity>().HasData(
                new CadastroCategoriaEntity()
                {
                    Id = new Guid("f14a5b01-4d1c-40c9-817c-c86f52933498"),
                    Ativo = true,
                    Name = "Terror",
                    CreateAt = DateTime.UtcNow
                }
                );
        }
    }
}
