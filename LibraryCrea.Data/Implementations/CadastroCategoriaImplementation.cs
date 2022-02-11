using LibraryCrea.Data.Context;
using LibraryCrea.Data.Repository;
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
    public class CadastroCategoriaImplementation : BaseRepository<CadastroCategoriaEntity>, ICadastroCategoriaRepository
    {
        private DbSet<CadastroCategoriaEntity> _dataset;

        public CadastroCategoriaImplementation(MyContext context) : base(context) => _dataset = context.Set<CadastroCategoriaEntity>();
    }
}
