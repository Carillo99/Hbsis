using IncomeTax.Services.Abstract;
using IncomeTax.Services.Interface;

namespace IncomeTax.Infra.Data.Interface
{
    public class ContributionIR : IContributionIR
    {
        private ContributionStrategy strategy;

        public decimal LiquidIncome(decimal grossIncome, int dependents, decimal MinimumWage)
        {
            decimal DiscountsPerDependent = (0.05M * grossIncome) * dependents;
            decimal liquidIncome = grossIncome - DiscountsPerDependent;

            if ((liquidIncome > 2 * MinimumWage) && (liquidIncome < 4 * MinimumWage))
            {
                strategy = new ContributionStrategyLow();
                return strategy.GetIR(liquidIncome);
            }

            else if ((liquidIncome > 4 * MinimumWage) && (liquidIncome < 5 * MinimumWage))
            {
                strategy = new ContributionStrategyMedium();
                return strategy.GetIR(liquidIncome);
            }

            else if ((liquidIncome > 5 * MinimumWage) && (liquidIncome < 7 * MinimumWage))
            {
                strategy = new ContributionStrategyHigh();
                return strategy.GetIR(liquidIncome);
            }

            else if (liquidIncome > 7 * MinimumWage)
            {
                strategy = new ContributionStrategyVeryHigh();
                return strategy.GetIR(liquidIncome);
            }
            else
            {
                return 0;
            }
        }
    }
}