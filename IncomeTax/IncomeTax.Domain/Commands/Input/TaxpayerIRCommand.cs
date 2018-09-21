using IncomeTax.Domain.Entities;

namespace IncomeTax.Domain.Commands.Input
{
    public class TaxpayerIRCommand
    {
        public int Id { get; set; }
        public decimal IR { get; set; }
        public int TaxpayerId { get; set; }
        
        public Taxpayer Taxpayer { get; set; }
    }
}