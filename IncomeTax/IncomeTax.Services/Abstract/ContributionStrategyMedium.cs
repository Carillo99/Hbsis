namespace IncomeTax.Services.Abstract
{
    public class ContributionStrategyMedium : ContributionStrategy
    {
        public override decimal getAliquota()
        {
            return 0.15M;
        }
    }
}
