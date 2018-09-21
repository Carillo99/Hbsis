using IncomeTax.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncomeTax.Infra.Data.Mapping
{
    public class TaxpayerMap : IEntityTypeConfiguration<Taxpayer>
    {
        public void Configure(EntityTypeBuilder<Taxpayer> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);
            
            builder.Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(c => c.NumberDependents)
                .IsRequired();

            builder.Property(c => c.GrossIncome)
                .IsRequired();
        }
    }
}
