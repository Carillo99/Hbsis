using IncomeTax.Services.Interface;

namespace IncomeTax.Infra.Data.Interface
{
    public class ContributionIR : IContributionIR
    {
        private readonly IServiceIR _serviceIR;

        public ContributionIR(IServiceIR serviceIR)
        {
            _serviceIR = serviceIR;
        }

        public decimal LiquidIncome(decimal grossIncome, int dependents, decimal MinimumWage)
        {
            decimal DiscountsPerDependent = ((5 * grossIncome) / 100) * dependents;
            decimal liquidIncome = grossIncome - DiscountsPerDependent;

            if ((liquidIncome > 2 * MinimumWage) && (liquidIncome < 4 * MinimumWage))
            {
                decimal aliquota = 7.5M;
                return _serviceIR.GetIR(liquidIncome, aliquota);
            }

            else if ((liquidIncome > 4 * MinimumWage) && (liquidIncome < 5 * MinimumWage))
            {
                decimal aliquota = 15;
                return _serviceIR.GetIR(liquidIncome, aliquota);
            }

            else if ((liquidIncome > 5 * MinimumWage) && (liquidIncome < 7 * MinimumWage))
            {
                decimal aliquota = 22.5M;
                return _serviceIR.GetIR(liquidIncome, aliquota);
            }

            else if (liquidIncome > 7 * MinimumWage)
            {
                decimal aliquota = 27.5M;
                return _serviceIR.GetIR(liquidIncome, aliquota);
            }
            else
            {
                return 0;
            }

        }
    }
}
