using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Domain.Entities;

namespace Info.Application.Common.Interfaces
{
    public interface ISpecificationRepository : IRepository<Specification>
    {
        void Update(Specification entity);
    }
}
