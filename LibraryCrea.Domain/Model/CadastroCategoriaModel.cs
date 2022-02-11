using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Model
{
    public class CadastroCategoriaModel
    {
        private Guid _Id;

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private bool _Ativo;

        public bool Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
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
