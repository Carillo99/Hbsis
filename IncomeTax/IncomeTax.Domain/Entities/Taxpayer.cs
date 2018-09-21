namespace IncomeTax.Domain.Entities
{
    public class Taxpayer : EntityBase
    {
        protected Taxpayer(){}

        public Taxpayer(string cpf, string name, int numberDependents, decimal grossIncome)
        {
            CPF = cpf;
            Name = name;
            NumberDependents = numberDependents;
            GrossIncome = grossIncome;
        }

        public string CPF { get; protected set; }
        public string Name { get; protected set; }
        public int NumberDependents { get; protected set; }
        public decimal GrossIncome { get; protected set; }

        public virtual TaxpayerIR TaxpayerIR { get; set; }
        public MinimumWage MinimumWage { get; set; }
    }
}