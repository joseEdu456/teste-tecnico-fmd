using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }
        public bool IsDeleted { get; private set; }

        public BaseEntity()
        {
            IsDeleted = false;
        }

        public void SetDeleted()
        {
            IsDeleted = true;
        }
    }
}
