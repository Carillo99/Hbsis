namespace IncomeTax.Services.Abstract
{
    public abstract class ContributionStrategy
    {
        public decimal GetIR(decimal liquidIncome)
        {
            return getAliquota() * liquidIncome;
        }

        public abstract decimal getAliquota();
    }
}
