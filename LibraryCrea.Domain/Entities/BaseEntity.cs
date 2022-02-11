using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        private DateTime? _CreateAt;

        public DateTime? CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }
}
