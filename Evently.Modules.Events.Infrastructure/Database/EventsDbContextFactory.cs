using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Evently.Modules.Events.Infrastructure.Database
{
    public class EventsDbContextFactory : IDesignTimeDbContextFactory<EventsDbContext>
    {
        public EventsDbContext CreateDbContext(string[] args)
        {
            var connectionString =
                @"Host=evently.database;Port=5012;Database=evently;Username=postgres;Password=postgres;Include Error Detail=true";

            var optionsBuilder = new DbContextOptionsBuilder<EventsDbContext>();
            optionsBuilder.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
            
            return new EventsDbContext(optionsBuilder.Options);
        }
    }
}