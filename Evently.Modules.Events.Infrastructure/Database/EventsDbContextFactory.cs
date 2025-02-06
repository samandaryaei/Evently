using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Evently.Modules.Events.Infrastructure.Database;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class EventsDbContextFactory : IDesignTimeDbContextFactory<EventsDbContext>
{
    public EventsDbContext CreateDbContext(string[] args)
    {
        var connectionString =
            @"Host=localhost;Port=5432;Database=evently;Username=postgres;Password=postgres;Include Error Detail=true"; //configuration.GetConnectionString("DataBase");

        var optionsBuilder = new DbContextOptionsBuilder<EventsDbContext>();
        optionsBuilder.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();

        return new EventsDbContext(optionsBuilder.Options);
    }
}

public class MockPublisher : IPublisher
{
    public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default)
        where TNotification : INotification
    {
        return Task.CompletedTask;
    }

    public Task Publish(object notification, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}