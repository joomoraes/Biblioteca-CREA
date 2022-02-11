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
    public class CadastroLivroMap : IEntityTypeConfiguration<CadastroLivroEntity>
    {
        public void Configure(EntityTypeBuilder<CadastroLivroEntity> builder)
        {
            builder.ToTable("CadastroLivro");

            builder.HasKey(x => x.Id);
            
            builder.HasIndex(x => x.ISBN).IsUnique();
            builder.Property(x => x.ISBN);

            builder.Property(x => x.Titulo);
            builder.Property(x => x.Editora);
            builder.Property(x => x.Edicao);
            builder.Property(x => x.Ano);
            builder.Property(x => x.situacao);

            builder.Property(x => x.CreateAt);
            builder.Property(x => x.UpdateAt);

            builder.Property(x => x.AutorId);
            builder.HasOne(x => x.Autor);

            builder.Property(x => x.CategoriaId);
            builder.HasOne(x => x.Categoria);



        }
    }
}
