
using LibraryCrea.Domain.Dtos.CadastroLivro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Interface.Service.CadastroLivro
{
    public interface ICadastroLivroService
    {
        Task<CadastroLivroDto> Get(Guid id);
        Task<IEnumerable<CadastroLivroDto>> GetAll();
        Task<CadastroLivroDtoCreateResult> Post(CadastroLivroDtoCreate cadastroLivro);
        Task<CadastroLivroDtoUpdateResult> Put(CadastroLivroDtoUpdate cadastroLivro);
        Task<bool> Delete(Guid id);
    }
}
