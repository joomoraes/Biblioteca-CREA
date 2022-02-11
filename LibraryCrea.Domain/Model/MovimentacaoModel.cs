using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryCrea.Domain.Dtos.Movimentacao.MovimentacaoDto;

namespace LibraryCrea.Domain.Model
{
    public class MovimentacaoModel
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        private CadastroLivroEntity _Livro;

        public CadastroLivroEntity Livro
        {
            get { return _Livro; }
            set { _Livro = value; }
        }

        private Guid _LivroId;

        public Guid LivroId
        {
            get { return _LivroId; }
            set { _LivroId = value; }
        }

        private PessoaEntity _PessoaEmprestimo;

        public PessoaEntity PessoaEmprestimo
        {
            get { return _PessoaEmprestimo; }
            set { _PessoaEmprestimo = value; }
        }

        private Guid _PessoaEmprestimoId;

        public Guid PessoaEmprestimoId
        {
            get { return _PessoaEmprestimoId; }
            set { _PessoaEmprestimoId = value; }
        }

        private PessoaEntity _PessoaResponsavel;

        public PessoaEntity PessoaResponsavel
        {
            get { return _PessoaResponsavel; }
            set { _PessoaResponsavel = value; }
        }

        private Guid _PessoaResponsavelId;

        public Guid PessoaResponsavelId
        {
            get { return _PessoaResponsavelId; }
            set { _PessoaResponsavelId = value; }
        }

        private DateTime _MaxDevolucacao;

        public DateTime MaxDevolucao
        {
            get { return _MaxDevolucacao; }
            set { _MaxDevolucacao = value; }
        }

        private DateTime _Devolucao;

        public DateTime Devolucao
        {
            get { return _Devolucao; }
            set { _Devolucao = value; }
        }

        private SituacaoEmprestimo _situacaoEmprestimo;

        public SituacaoEmprestimo situacaoEmprestimo
        {
            get { return _situacaoEmprestimo; }
            set { _situacaoEmprestimo = value; }
        }

        private DateTime? _CreateAt;

        public DateTime? CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = value; }
        }

        private DateTime? _UpdateAt;

        public DateTime? UpdateAt
        {
            get { return _UpdateAt; }
            set { _UpdateAt = value; }
        }


    }
}
