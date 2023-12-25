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
    public class SkillRepository : Repository<Skill>, ISkillRepository
    {
        private readonly ApplicationDbContext _db;
        public SkillRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Skill entity)
        {
            _db.Update(entity);
        }
    }
}
