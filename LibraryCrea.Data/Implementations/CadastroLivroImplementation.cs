using Api.Data.Repository;
using LibraryCrea.Data.Context;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Implementations
{
    public class CadastroLivroImplementation : BaseRepository<CadastroLivroEntity>, ICadastroLivroRepository
    {
        private DbSet<CadastroCategoriaEntity> _dataset;

        public CadastroLivroImplementation(MyContext context) : base(context) => _dataset = context.Set<CadastroCategoriaEntity>();
        
    }
}
