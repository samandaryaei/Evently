using System;
using System.Threading;
using System.Threading.Tasks;

namespace Evently.Modules.Events.Domain.Events;

public interface IEventRepository
{
    Task<Event> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Event @event);
}