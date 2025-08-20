using Microsoft.Extensions.Configuration;
using CleanArchitecture.Domain.Entities;
namespace CleanArchitecture.Infrastructure.Persistence.Contexts;

public class BaseDbContext : UnitOfWork
{
    public BaseDbContext(IOptions<UnitOfWorkOptions> options,
        IAuditPropertyInterceptorManager auditPropertyInterceptorManager
        , DbContextOptions<BaseDbContext> dbContextOptions
        , IAuditBehaviourService auditBehaviourService
        , IConfiguration configuration) : base(options, dbContextOptions, auditPropertyInterceptorManager, auditBehaviourService, configuration)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}