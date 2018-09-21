namespace IncomeTax.Domain.Entities
{
    public class MinimumWage : EntityBase
    {
        protected MinimumWage() { }

        public MinimumWage(decimal minimumWageBase, int taxpayerId)
        {
            MinimumWageBase = minimumWageBase;
            TaxpayerId = taxpayerId;
        }

        public decimal MinimumWageBase { get; protected set; }
        public int TaxpayerId { get; protected set; }

        public virtual Taxpayer Taxpayer { get; protected set; }
    }
}
