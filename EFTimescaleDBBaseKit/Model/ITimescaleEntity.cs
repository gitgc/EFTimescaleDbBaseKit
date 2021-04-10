using System;

namespace EFTimescaleDBBaseKit.Model
{
    /// <summary>
    /// Columns required by all TimescaleDB HyperTable rows.
    /// </summary>
    public interface ITimescaleEntity
    {
        /// <summary>
        /// Gets or sets id.
        /// future.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets created at.
        /// </summary>
        DateTime CreatedAt { get; set; }
    }
}
