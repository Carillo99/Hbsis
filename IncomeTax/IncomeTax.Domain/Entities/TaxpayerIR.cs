namespace IncomeTax.Domain.Entities
{
    public class TaxpayerIR : EntityBase
    {
        protected TaxpayerIR() { }

        public TaxpayerIR(decimal ir, int taxpayerId)
        {
            IR = ir;
            TaxpayerId = taxpayerId;
        }

        public decimal IR { get; protected set; }
        public int TaxpayerId { get; protected set; }

        public virtual Taxpayer Taxpayer { get; protected set; }
    }
}
