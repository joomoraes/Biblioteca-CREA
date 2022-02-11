

using LibraryCrea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryCrea.Data.Mappings
{
    public class CadastroCategoriaMap : IEntityTypeConfiguration<CadastroCategoriaEntity>
    {
        public void Configure(EntityTypeBuilder<CadastroCategoriaEntity> builder)
        {
            builder.ToTable("CadastroCategoria");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.CreateAt);
            builder.Property(x => x.UpdateAt);
        }
    }
}
