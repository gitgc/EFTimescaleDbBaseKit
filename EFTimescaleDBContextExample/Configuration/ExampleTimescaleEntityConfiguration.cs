using EFTimescaleDBBaseKit.Model;
using EFTimescaleDBBaseKit.Model.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFTimescaleDBContextExample.Model.Configuration
{
    /// <summary>
    /// Example fluent api configuration for the ExampleTimeScaleEntity table.
    /// </summary>
    public class ExampleTimescaleEntityConfiguration : AbstractTimescaleEntityConfiguration<ExampleTimescaleEntity>
    {
        /// <inheritdoc/>
        public override void Configure(EntityTypeBuilder<ExampleTimescaleEntity> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(120);
        }
    }
}
