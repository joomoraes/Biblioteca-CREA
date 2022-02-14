using LibraryCrea.Domain.Dtos.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryCrea.Domain.Dtos.Pessoa.PessoaDto;

namespace LibraryCrea.Domain.Model
{
    public class PessoaModel
    {

        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        private string _Matricula;

        public string Matricula
        {
            get { return _Matricula; }
            set { _Matricula = value; }
        }

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private int _RG;

        public int RG
        {
            get { return _RG; }
            set { _RG = value; }
        }

        private string _CPF;

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        private Tipo _tipo;

        public Tipo tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private bool _Ativo;

        public bool Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }



    }
}
