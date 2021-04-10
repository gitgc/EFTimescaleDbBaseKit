using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EFTimescaleDBBaseKit
{
    /// <summary>
    /// TimescaleDbContext abstract implementation of <see cref="DbContext"/>.
    /// </summary>
    public abstract class AbstractTimescaleDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTimescaleDbContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public AbstractTimescaleDbContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
