using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Repository;
using IncomeTax.Infra.Data.Context;

namespace IncomeTax.Infra.Data.Repository
{
    public class TaxpayerIRRepository : Repository<TaxpayerIR>, ITaxpayerIRRepository
    {
        public TaxpayerIRRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
