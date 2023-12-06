using Info.Application.Common.Interfaces;
using Info.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ISpecificationRepository Specification { get; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db=db;
            Specification = new SpecificationRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        
    }
}
