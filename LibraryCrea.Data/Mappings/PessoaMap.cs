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
    public class PessoaMap : IEntityTypeConfiguration<PessoaEntity>
    {
        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Matricula);
            builder.Property(x => x.Nome);
            builder.Property(x => x.RG);
            builder.Property(x => x.CPF);
            builder.Property(x => x.tipo);
            builder.Property(x => x.Ativo);
            builder.HasMany(x => x.dadosParaContato);
            builder.Property(x => x.CreateAt);
            builder.Property(x => x.UpdateAt);
        }
    }
}
