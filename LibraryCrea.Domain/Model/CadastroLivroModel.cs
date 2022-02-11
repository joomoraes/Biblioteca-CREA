using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryCrea.Domain.Dtos.CadastroLivro.CadastroLivroDto;

namespace LibraryCrea.Domain.Model
{
    public class CadastroLivroModel
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _ISBN;

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        private string _Titulo;

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        private string _Editora;

        public string Editora
        {
            get { return _Editora; }
            set { _Editora = value; }
        }

        private string _Edicao;

        public string Edicao
        {
            get { return _Edicao; }
            set { _Edicao = value; }
        }

        private DateTime _Ano;

        public DateTime Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }

        private Situacao _situacao;

        public Situacao situacao
        {
            get { return _situacao; }
            set { _situacao = value; }
        }

        private PessoaEntity _Autor;

        public PessoaEntity Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        private Guid _AutorId;

        public Guid AutorId
        {
            get { return _AutorId; }
            set { _AutorId = value; }
        }

        private CadastroCategoriaEntity _Categoria;

        public CadastroCategoriaEntity Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private Guid _CategoriaId;

        public Guid CategoriaId
        {
            get { return _CategoriaId; }
            set { _CategoriaId = value; }
        }

        private DateTime _CreateAt;

        public DateTime CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = value; }
        }

        private DateTime _UpdateAt;

        public DateTime UpdateAt
        {
            get { return _UpdateAt; }
            set { _UpdateAt = value; }
        }


    }
}
