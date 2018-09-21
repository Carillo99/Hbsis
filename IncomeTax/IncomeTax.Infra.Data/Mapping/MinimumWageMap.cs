using IncomeTax.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncomeTax.Infra.Data.Mapping
{
    class MinimumWageMap : IEntityTypeConfiguration<MinimumWage>
    {
        public void Configure(EntityTypeBuilder<MinimumWage> builder)
        {
            builder.Property(c => c.MinimumWageBase)
                .IsRequired();

            builder.Property(c => c.TaxpayerId)
                .IsRequired();
        }
    }
}
