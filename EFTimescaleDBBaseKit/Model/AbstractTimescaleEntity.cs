using System;

namespace EFTimescaleDBBaseKit.Model
{
    /// <inheritdoc/>
    public abstract class AbstractTimescaleEntity : ITimescaleEntity
    {
        /// <inheritdoc/>
        public Guid Id { get; set; }

        /// <inheritdoc/>
        public DateTime CreatedAt { get; set; }
    }
}
