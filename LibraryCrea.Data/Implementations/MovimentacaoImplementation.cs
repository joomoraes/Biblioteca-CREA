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
    public class MovimentacaoImplementation : BaseRepository<MovimentcaoEntity>, IMovimentacaoRepository
    {
        private DbSet<MovimentcaoEntity> _dataset;

        public MovimentacaoImplementation(MyContext context) : base(context) => _dataset = context.Set<MovimentcaoEntity>();
        
    }
}
