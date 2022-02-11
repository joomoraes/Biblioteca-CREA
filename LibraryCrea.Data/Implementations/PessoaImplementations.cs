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
    public class PessoaImplementations : BaseRepository<PessoaEntity>, IPessoaRepository
    {
        private DbSet<PessoaEntity> _dataset;

        public PessoaImplementations(MyContext context) : base(context) => _dataset = context.Set<PessoaEntity>();
    }
}
