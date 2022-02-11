using AutoMapper;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<CadastroCategoriaModel, CadastroCategoriaEntity>()
                .ReverseMap();

            CreateMap<CadastroLivroModel, CadastroLivroEntity>()
                .ReverseMap();

            CreateMap<MovimentacaoModel, MovimentcaoEntity>()
                .ReverseMap();

            CreateMap<PessoaModel, PessoaEntity>()
                .ReverseMap();
        }
    }
}
