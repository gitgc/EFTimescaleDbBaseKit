using EFTimescaleDBBaseKit.Model;

namespace EFTimescaleDBContextExample.Model
{
    /// <inheritdoc/>
    public class ExampleTimescaleEntity : AbstractTimescaleEntity, IExampleTimescaleEntity
    {
        /// <inheritdoc/>
        public string Name { get; set; }
    }
}
