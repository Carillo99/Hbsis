using IncomeTax.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncomeTax.Infra.Data.Mapping
{
    public class TaxpayerIRMap : IEntityTypeConfiguration<TaxpayerIR>
    {
        public void Configure(EntityTypeBuilder<TaxpayerIR> builder)
        {
            builder.Property(c => c.IR)
                .IsRequired();

            builder.Property(c => c.TaxpayerId)
                .IsRequired();
        }
    }
}
