using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Evently.Modules.Events.Application.Abstractions.Data;
using MediatR;

namespace Evently.Modules.Events.Application.Events.GetEvent;

internal sealed class GetEventQueryHandler(IDbConnectionFactory dbConnectionFactory) 
    : IRequestHandler<GetEventQuery, EventResponse?>
{
    public async Task<EventResponse> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        await using DbConnection connection = await dbConnectionFactory.OpenConnectionAsync();
        
        const string sql = $"""
                                SELECT 
                                    id AS {nameof(EventResponse.Id)},
                                    title AS {nameof(EventResponse.Title)},
                                    description AS {nameof(EventResponse.Description)},
                                    location AS {nameof(EventResponse.Location)},
                                    start_at_utc AS {nameof(EventResponse.StartsAtUtc)},
                                    end_at_utc AS {nameof(EventResponse.EndsAtUtc)}
                                FROM events.events
                                WHERE id = @EventId
                            """;
        EventResponse? @events = 
            await connection.QuerySingleOrDefaultAsync(sql, request);

        return @events;
    }
}