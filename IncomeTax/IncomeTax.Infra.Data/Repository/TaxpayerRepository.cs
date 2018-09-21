using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Repository;
using IncomeTax.Infra.Data.Context;

namespace IncomeTax.Infra.Data.Repository
{
    public class TaxpayerRepository : Repository<Taxpayer>, ITaxpayerRepository
    {
        public TaxpayerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
