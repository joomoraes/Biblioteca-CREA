using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Mappings
{
    public class MovimentacaoMap : IEntityTypeConfiguration<MovimentcaoEntity>
    {
        public void Configure(EntityTypeBuilder<MovimentcaoEntity> builder)
        {
            builder.ToTable("Movimentacao");

            builder.HasKey(x => x.Id);


            builder.Property(x => x.LivroId);

            builder.Property(x => x.PessoaEmprestimoId);

            builder.Property(x => x.MaxDevolucacao);
            builder.Property(x => x.Devolucao);
            builder.Property(x => x.situacaoEmprestimo);

            builder.Property(x => x.CreateAt);
            builder.Property(x => x.UpdateAt);
        }
    }
}
