using AutoMapper;
using LibraryCrea.Domain.Dtos.CadastroCategoria;
using LibraryCrea.Domain.Dtos.CadastroLivro;
using LibraryCrea.Domain.Dtos.Movimentacao;
using LibraryCrea.Domain.Dtos.Pessoa;
using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<CadastroCategoriaDto, CadastroCategoriaEntity>()
                .ReverseMap();

            CreateMap<CadastroCategoriaDtoCreateResult, CadastroCategoriaEntity>()
                .ReverseMap();

            CreateMap<CadastroCategoriaDtoUpdateResult, CadastroCategoriaEntity>();

            CreateMap<CadastroLivroDto, CadastroLivroEntity>()
                .ReverseMap();

            CreateMap<CadastroLivroDtoCreateResult, CadastroLivroEntity>()
                .ReverseMap();

            CreateMap<CadastroLivroDtoUpdateResult, CadastroLivroEntity>()
                .ReverseMap();

            CreateMap<MovimentacaoDto, MovimentcaoEntity>()
                .ReverseMap();

            CreateMap<MovimentacaoDtoCreateResult, MovimentcaoEntity>()
                .ReverseMap();

            CreateMap<MovimentacaoDtoUpdateResult, MovimentcaoEntity>()
                .ReverseMap();

            CreateMap<PessoaDto, PessoaEntity>()
                .ReverseMap();

            CreateMap<PessoaDtoCreateResult, PessoaEntity>()
                .ReverseMap();

            CreateMap<PessoaDtoUpdateResult, PessoaEntity>()
                .ReverseMap();
        }
    }
}
