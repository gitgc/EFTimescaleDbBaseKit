using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EFTimescaleDBContextExample
{
    /// <summary>
    /// Implements the IDesignTimeDBContextFactory contract, allows you to rebuild schema via ef CLI.
    /// Loads connection string from local json file.
    /// </summary>
    public class ContextFactory : IDesignTimeDbContextFactory<ExampleTimescaleDbContext>
    {
        /// <inheritdoc/>
        public ExampleTimescaleDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = LoadConfiguration();

            DbContextOptionsBuilder<ExampleTimescaleDbContext> optionsBuilder =
                new DbContextOptionsBuilder<ExampleTimescaleDbContext>()
                    .UseNpgsql(
                        configuration["ConnectionString:TimescaleDB"],
                        providerOptions => providerOptions.EnableRetryOnFailure());

            return new ExampleTimescaleDbContext(optionsBuilder.Options);
        }

        private static IConfigurationRoot LoadConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("connection.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            return configuration;
        }
    }
}
