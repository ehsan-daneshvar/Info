using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        ISpecificationRepository Specification { get; }

    }
}
