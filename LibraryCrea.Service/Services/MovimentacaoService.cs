using AutoMapper;
using LibraryCrea.Domain.Dtos.Movimentacao;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Interface.Service;
using LibraryCrea.Domain.Interface.Service.Movimentacao;
using LibraryCrea.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Service.Services
{
    public class MovimentacaoService : IMovimentacaoService
    {
        private IRepository<MovimentcaoEntity> _repository;

        private IMapper _mapper;

        public MovimentacaoService(IRepository<MovimentcaoEntity> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MovimentacaoDto> Get(Guid Id)
        {
            var entity = await _repository.SelecAsync(Id);
            return _mapper.Map<MovimentacaoDto>(entity);
        }

        public async Task<IEnumerable<MovimentacaoDto>> GetAll()
        {
            var entityList = await _repository.SelecAsync();
            return _mapper.Map<IEnumerable<MovimentacaoDto>>(entityList);
        }

        public async Task<MovimentacaoDtoCreateResult> Post(MovimentacaoDtoCreate movimentacao)
        {
            var model = _mapper.Map<MovimentacaoModel>(movimentacao);
            var entity = _mapper.Map<MovimentcaoEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<MovimentacaoDtoCreateResult>(result);
        }

        public async Task<MovimentacaoDtoUpdateResult> Put(MovimentacaoDtoUpdate movimentacao)
        {
            var model = _mapper.Map<MovimentacaoModel>(movimentacao);
            var entity = _mapper.Map<MovimentcaoEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<MovimentacaoDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
