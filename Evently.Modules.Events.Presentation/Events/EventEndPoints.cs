using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Events;

public static class EventEndPoints
{
    public static void MapEndPoints(IEndpointRouteBuilder app)
    {
        CreateEvent.MapEndpoint(app);
        GetEvent.MapEndpoint(app);
    }
}