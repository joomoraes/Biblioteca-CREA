using AutoMapper;
using LibraryCrea.Domain.Dtos.CadastroCategoria;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Interface.Service;
using LibraryCrea.Domain.Model;
using LibraryCrea.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Service.Services
{
    public class CadastroCategoriaService : ICadastroCategoriaService
    {
        private IRepository<CadastroCategoriaEntity> _repository;

        private readonly IMapper _mapper;

        public CadastroCategoriaService(IRepository<CadastroCategoriaEntity> repository,
            IMapper mapper)
        {
            _repository = repository;   
            _mapper = mapper;   
        }

        public async Task<CadastroCategoriaDto> Get(Guid id)
        {
            var entity = await _repository.SelecAsync(id);
            return _mapper.Map<CadastroCategoriaDto>(entity);
        }

        public async Task<IEnumerable<CadastroCategoriaDto>> GetAll()
        {
            var listEntity = await _repository.SelecAsync();
            return _mapper.Map<IEnumerable<CadastroCategoriaDto>>(listEntity);
        }

        public async Task<CadastroCategoriaDtoCreateResult> Post(CadastroCategoriaDtoCreate cadastroCategoria)
        {
            var model = _mapper.Map<CadastroCategoriaModel>(cadastroCategoria);
            var entity = _mapper.Map<CadastroCategoriaEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<CadastroCategoriaDtoCreateResult>(result);
        }

        public async Task<CadastroCategoriaDtoUpdateResult> Put(CadastroCategoriaDtoUpdate cadastroCategoria)
        {
            var model = _mapper.Map<CadastroCategoriaModel>(cadastroCategoria);
            var entity = _mapper.Map<CadastroCategoriaEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return  _mapper.Map<CadastroCategoriaDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);   
        }
    }
}
