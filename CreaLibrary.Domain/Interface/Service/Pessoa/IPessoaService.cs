using LibraryCrea.Domain.Dtos.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Interface.Service.Pessoa
{
    public interface IPessoaService
    {
        Task<PessoaDto> Get(Guid Id);
        Task<IEnumerable<PessoaDto>> GetAll();
        Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoa);
        Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate pessoa);
        Task<bool> Delete(Guid id);
    }
}
