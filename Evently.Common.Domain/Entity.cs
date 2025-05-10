using System.Collections.Generic;
using System.Linq;

namespace Evently.Common.Domain;

public abstract class Entity
{
    protected Entity()
    {
    }
    private readonly List<IDomainEvent> _domainEvents =[];
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.ToList();
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}