using System.Reflection;
using EFTimescaleDBBaseKit;
using EFTimescaleDBContextExample.Model;
using Microsoft.EntityFrameworkCore;

namespace EFTimescaleDBContextExample
{
    /// <summary>
    /// Example <see cref="AbstractTimescaleDbContext"/> implementation.
    /// </summary>
    public class ExampleTimescaleDbContext : AbstractTimescaleDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleTimescaleDbContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public ExampleTimescaleDbContext(DbContextOptions<ExampleTimescaleDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="ExampleTimescaleEntity"/> DbSet.
        /// </summary>
        public virtual DbSet<ExampleTimescaleEntity> ExampleTimescaleEntities { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
