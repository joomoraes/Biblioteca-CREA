using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Dtos.Movimentacao
{
    public class MovimentacaoDtoCreate
    { 

        public Guid LivroId { get; set; }
        public Guid PessoaEmprestimoId { get; set; }

        public Guid PessoaResponsavelId { get; set; }

        public DateTime MaxDevolucacao { get; set; }
        public DateTime Devolucao { get; set; }
        public SituacaoEmprestimo situacaoEmprestimo { get; set; }


        public enum SituacaoEmprestimo
        {
            Emprestado,
            Atrasado,
            Devolvido
        }
    }
}
