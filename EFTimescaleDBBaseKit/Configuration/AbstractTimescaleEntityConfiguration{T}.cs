using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFTimescaleDBBaseKit.Model.Configuration
{
    /// <summary>
    /// Base class for all <see cref="ITimescaleEntity"/> configurations. Takes care of mandatory columns.
    /// </summary>
    /// <typeparam name="T"><see cref="ITimescaleEntity"/>.</typeparam>
    public abstract class AbstractTimescaleEntityConfiguration<T> : IEntityTypeConfiguration<T>
        where T : class, ITimescaleEntity
    {
        /// <inheritdoc/>
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => new { e.Id, e.CreatedAt });

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.CreatedAt)
                .ValueGeneratedOnAdd()
                .HasColumnType("timestamptz");

            builder.HasIndex(e => e.CreatedAt);
        }
    }
}
