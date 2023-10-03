using PANetWebApi.Domain.Common;

namespace PANetWebApi.Domain.Interfaces.Common;

public interface IHasDomainEvent
{
    public IReadOnlyCollection<DomainEvent> RegisteredDomainEvents { get; }
}