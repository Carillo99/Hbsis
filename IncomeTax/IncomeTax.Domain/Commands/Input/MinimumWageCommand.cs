using IncomeTax.Domain.Entities;

namespace IncomeTax.Domain.Commands.Input
{
    public class MinimumWageCommand
    {
        public int Id { get; set; }
        public decimal MinimumWageBase { get; set; }
        public int TaxpayerId { get; set; }
        
        public virtual Taxpayer Taxpayer { get; set; }
    }
}
