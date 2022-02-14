using LibraryCrea.Data.Mappings;
using LibraryCrea.Data.Seeds;
using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<CadastroCategoriaEntity> CadastroCategoria { get; set; }
        public DbSet<CadastroLivroEntity> CadastroLivro { get; set; }
        public DbSet<MovimentcaoEntity> Movimentacao { get; set; }
        public DbSet<PessoaEntity> Pessoa {get; set;}

        public MyContext(DbContextOptions<MyContext> options) : base(options)   
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CadastroCategoriaEntity>(new CadastroCategoriaMap().Configure);
            modelBuilder.Entity<CadastroLivroEntity>(new CadastroLivroMap().Configure);
            modelBuilder.Entity<MovimentcaoEntity>(new MovimentacaoMap().Configure);
            modelBuilder.Entity<PessoaEntity>(new PessoaMap().Configure);

            CadastroCategoriaSeeds.CadastroCategoria(modelBuilder);
            CadastroLivroSeeds.CadastroLivro(modelBuilder);
            MovimentacaoSeeds.Movimentacao(modelBuilder);
            PessoaSeeds.Pessoa(modelBuilder);
        }
    }
}
