using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Entities
{
    public class MovimentcaoEntity : BaseEntity
    {
        public virtual MovimentcaoEntity Movimentacao { get; set; }
        public Guid MovimentacaoId { get; set; }

        public virtual CadastroLivroEntity Livro { get; set; }
        public Guid LivroId { get; set; }
        public virtual PessoaEntity PessoaEmprestimo { get; set; }
        public Guid PessoaEmprestimoId { get; set; }

        public virtual PessoaEntity PessoaResponsavel { get; set; }
        public Guid PessoaResponsavelId { get; set; }

        public DateTime MaxDevolucacao { get; set; }
        public DateTime Devolucao { get; set; }

        public enum SituacaoEmprestimo
        {
            Emprestado, 
            Atrasado,
            Devolvido
        }
    }

}
