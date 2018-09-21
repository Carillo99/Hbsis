namespace IncomeTax.Services.Interface
{
    public interface IContributionIR
    {
        decimal LiquidIncome(decimal grossIncome, int dependents, decimal MinimumWage);
    }
}
