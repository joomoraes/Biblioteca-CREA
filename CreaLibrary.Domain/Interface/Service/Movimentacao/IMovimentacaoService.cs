using LibraryCrea.Domain.Dtos.Movimentacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Interface.Service.Movimentacao
{
    public interface IMovimentacaoService
    {
        Task<MovimentacaoDto> Get(Guid Id);
        Task<IEnumerable<MovimentacaoDto>> GetAll();
        Task<MovimentacaoDtoCreateResult> Post(MovimentacaoDtoCreate movimentacao);
        Task<MovimentacaoDtoUpdateResult> Put(MovimentacaoDtoUpdate movimentacao);
        Task<bool> Delete(Guid id);
    }
}
