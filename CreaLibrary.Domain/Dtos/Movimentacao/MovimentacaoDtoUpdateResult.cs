using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Dtos.Movimentacao
{
    public class MovimentacaoDtoUpdateResult
    {
        [Display(Name = "ISBN", Description = "Cadastro Único de Livro")]
        [Required(ErrorMessage = "O Cadastro Único de Livro é Obrigatório")]
        public string ISBN { get; set; }

        [Display(Name = "Título", Description = "Título do Livro")]
        [Required(ErrorMessage = "O título do livro é obrigatório")]
        public string Titulo { get; set; }

        [Display(Name = "Editora", Description = "Nome Editora Livro")]
        [Required(ErrorMessage = "Editora Deve Ser Obrigatório")]
        public string Editora { get; set; }

        [Display(Name = "Edição", Description = "Edição Livro")]
        [Required(ErrorMessage = "Edição deve ser obrigatória")]
        public string Edicao { get; set; }
        [Display(Name = "Ano", Description = "Ano da Puplicão")]
        [Required(ErrorMessage = "O ano deve ser obrigatório"]
        public DateTime Ano { get; set; }

        public Situacao situacao { get; set; }

        public virtual PessoaEntity Autor { get; set; }
        public Guid AutorId { get; set; }
        public virtual CadastroCategoriaEntity Categoria { get; set; }
        public Guid CategoriaId { get; set; }
        public enum Situacao
        {
            Disponivel,
            Emprestado,
            Extraviado,
            Manutencao
        }

        public DateTime UpdateAt { get; set; }
    }
}
