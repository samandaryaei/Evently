using System;

namespace Evently.Modules.Events.Domain.Abstractions;

public interface IDomainEvent
{
    Guid Id { get; }
    DateTime OccurredOnUtc { get; }
}