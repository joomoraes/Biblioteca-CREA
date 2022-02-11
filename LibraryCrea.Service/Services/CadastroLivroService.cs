using AutoMapper;
using LibraryCrea.Domain.Dtos.CadastroLivro;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Interface.Service;
using LibraryCrea.Domain.Interface.Service.CadastroLivro;
using LibraryCrea.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Service.Services
{
    public class CadastroLivroService : ICadastroLivroService
    {
        private IRepository<CadastroLivroEntity> _repository;

        private IMapper _mapper;

        public CadastroLivroService(IRepository<CadastroLivroEntity> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CadastroLivroDto> Get(Guid id)
        {
            var entity = await _repository.SelecAsync(id);
            return _mapper.Map<CadastroLivroDto>(entity);
        }

        public async Task<IEnumerable<CadastroLivroDto>> GetAll()
        {
            var listaEntity = await _repository.SelecAsync();
            return _mapper.Map<IEnumerable<CadastroLivroDto>>(listaEntity);
        }

        public async Task<CadastroLivroDtoCreateResult> Post(CadastroLivroDtoCreate cadastroLivro)
        {
            var model = _mapper.Map<CadastroLivroModel>(cadastroLivro);
            var entity = _mapper.Map<CadastroLivroEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<CadastroLivroDtoCreateResult>(result);
        }

        public async Task<CadastroLivroDtoUpdateResult> Put(CadastroLivroDtoUpdate cadastroLivro)
        {
            var model = _mapper.Map<CadastroLivroModel>(cadastroLivro);
            var entity = _mapper.Map<CadastroLivroEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<CadastroLivroDtoUpdateResult>(result);
        }
    }
}
