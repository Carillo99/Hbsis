namespace IncomeTax.Services.Abstract
{
    public class ContributionStrategyLow : ContributionStrategy
    {
        public override decimal getAliquota()
        {
            return 0.075M;
        }
    }
}
