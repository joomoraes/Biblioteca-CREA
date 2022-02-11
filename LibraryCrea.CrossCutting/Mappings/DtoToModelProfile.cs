using AutoMapper;
using LibraryCrea.Domain.Dtos.CadastroCategoria;
using LibraryCrea.Domain.Dtos.CadastroLivro;
using LibraryCrea.Domain.Dtos.Movimentacao;
using LibraryCrea.Domain.Dtos.Pessoa;
using LibraryCrea.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<CadastroCategoriaModel, CadastroCategoriaDto>()
                .ReverseMap();

            CreateMap<CadastroCategoriaModel, CadastroCategoriaDtoCreate>()
                .ReverseMap();

            CreateMap<CadastroCategoriaModel, CadastroCategoriaDtoUpdate>()
                .ReverseMap();

            CreateMap<CadastroLivroModel, CadastroLivroDto>()
                .ReverseMap();

            CreateMap<CadastroLivroModel, CadastroLivroDtoCreate>()
                .ReverseMap();

            CreateMap<CadastroLivroModel, CadastroLivroDtoUpdate>()
                .ReverseMap();

            CreateMap<MovimentacaoModel, MovimentacaoDto>()
                .ReverseMap();

            CreateMap<MovimentacaoModel, MovimentacaoDtoCreate>()
                .ReverseMap();

            CreateMap<MovimentacaoModel, MovimentacaoDtoUpdate>()
                .ReverseMap();

            CreateMap<PessoaModel, PessoaDto>()
                .ReverseMap();

            CreateMap<PessoaModel, PessoaDtoCreate>()
                .ReverseMap();

            CreateMap<PessoaModel, PessoaDtoUpdate>()
                .ReverseMap();
        }
    }
}
