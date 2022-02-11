using LibraryCrea.Domain.Dtos.CadastroCategoria;
using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Models
{
    public interface ICadastroCategoriaRepository
    {
        Task<CadastroCategoriaDto> Get(Guid id);
        Task<IEnumerable<CadastroCategoriaDto>> GetAll();
        Task<CadastroCategoriaDtoCreateResult> Post(CadastroCategoriaDtoCreate cadastroCategoria);
        Task<CadastroCategoriaDtoUpdateResult> Put(CadastroCategoriaDtoUpdate cadastroCategoria);
        Task<bool> Delete(Guid id);


    }
}
