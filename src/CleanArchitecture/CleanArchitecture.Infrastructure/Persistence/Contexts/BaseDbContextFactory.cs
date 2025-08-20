namespace CleanArchitecture.Infrastructure.Persistence.Contexts;

  public class BaseDbContextFactory : IDesignTimeDbContextFactory<BaseDbContext>
    {
        public BaseDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json")
                .Build();

            if (configuration == null)
            {
                throw new Exception("Configuration not found");
            }
            var connectionString = configuration.GetConnectionString("BaseConnectionString");
            if (connectionString == null)
            {
                throw new Exception($"Connection string not found in configuration at {Directory.GetCurrentDirectory()}");
            }
            var optionsBuilder = new DbContextOptionsBuilder<BaseDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new BaseDbContext(optionsBuilder.Options);
        }
    }