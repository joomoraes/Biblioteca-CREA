using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Seeds
{
    public class PessoaSeeds
    {
        public static void Pessoa(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaEntity>().HasData(
                new PessoaEntity()
                {
                    Id = new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"),
                    Ativo = true,
                    CPF = "000000000000",
                    dadosParaContato = new List<DadosParaContato>(),

                    Matricula = "0000000000",
                    Nome = "João",
                    RG = 11111111,
                    tipo = PessoaEntity.Tipo.Autor,
                    CreateAt = DateTime.Now
                }
                );
        }
    }
}
