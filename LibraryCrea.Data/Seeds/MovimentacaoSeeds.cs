using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Seeds
{
    public class MovimentacaoSeeds
    {
        public static void Movimentacao(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovimentcaoEntity>().HasData(
                new MovimentcaoEntity()
                {
                    Id = Guid.NewGuid(),
                    Devolucao = DateTime.Now,
                    LivroId = new Guid("7f3cf61a-fc9a-4840-bd6c-94e48a9884f9"),
                    MaxDevolucacao = DateTime.Now,
                    PessoaEmprestimoId = new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"),
                    PessoaResponsavelId = new Guid("0372a26c-f8b8-41d9-92c9-e43e492a1278"),
                    situacaoEmprestimo = MovimentcaoEntity.SituacaoEmprestimo.Devolvido,
                    CreateAt = DateTime.Now
                }
                );
        }
    }
}
