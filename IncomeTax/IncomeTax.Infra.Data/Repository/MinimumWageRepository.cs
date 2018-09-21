using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Repository;
using IncomeTax.Infra.Data.Context;

namespace IncomeTax.Infra.Data.Repository
{
    public class MinimumWageRepository : Repository<MinimumWage>, IMinimumWageRepository
    {
        public MinimumWageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
