namespace IncomeTax.Services.Abstract
{
    public class ContributionStrategyHigh : ContributionStrategy
    {
        public override decimal getAliquota()
        {
            return 0.225M;
        }
    }
}
