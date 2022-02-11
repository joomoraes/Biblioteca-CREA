using AutoMapper;
using LibraryCrea.Domain.Dtos.Pessoa;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Interface.Service;
using LibraryCrea.Domain.Interface.Service.Pessoa;
using LibraryCrea.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Service.Services
{
    public class PessoaService : IPessoaService
    {

        private IRepository<PessoaEntity> _repository;

        private IMapper _mapper;

        public PessoaService(IRepository<PessoaEntity> repository,
            IMapper mapper)
        {
            _repository = repository;   
            _mapper = mapper;   
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);   
        }

        public async Task<PessoaDto> Get(Guid Id)
        {
            var entity = await _repository.SelecAsync(Id);
            return _mapper.Map<PessoaDto>(entity);
        }

        public async Task<IEnumerable<PessoaDto>> GetAll()
        {
            var entityList = await _repository.SelecAsync();
            return _mapper.Map<IEnumerable<PessoaDto>>(entityList);
        }

        public async Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoa)
        {
            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<PessoaEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<PessoaDtoCreateResult>(result);
        }

        public async Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate pessoa)
        {
            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<PessoaEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PessoaDtoUpdateResult>(result);
        }
    }
}
