using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Application.Common.Interfaces;
using Info.Domain.Entities;
using Info.Infrastructure.Data;

namespace Info.Infrastructure.Repository
{
    public class SpecificationRepository:Repository<Specification> , ISpecificationRepository
    {
        private readonly ApplicationDbContext _db;
        public SpecificationRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Specification entity)
        {
            _db.Update(entity);
        }
    }
}
