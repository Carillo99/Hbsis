namespace IncomeTax.Domain.Commands.Input
{
    public class TaxpayerCommand
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public int NumberDependents { get; set; }
        public decimal GrossIncome { get; set; }
    }
}
