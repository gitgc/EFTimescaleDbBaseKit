using EFTimescaleDBBaseKit.Model;

namespace EFTimescaleDBContextExample.Model
{
    /// <summary>
    /// Basic example entity.
    /// </summary>
    public interface IExampleTimescaleEntity : ITimescaleEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }
    }
}
