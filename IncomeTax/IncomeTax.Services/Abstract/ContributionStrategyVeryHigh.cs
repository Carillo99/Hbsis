namespace IncomeTax.Services.Abstract
{
    public class ContributionStrategyVeryHigh : ContributionStrategy
    {
        public override decimal getAliquota()
        {
            return 0.275M;
        }
    }
}
