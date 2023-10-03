using System.ComponentModel.DataAnnotations;
using PANetWebApi.Domain.Common;
using PANetWebApi.Domain.Interfaces.Common;

namespace PANetWebApi.Domain.Entities;

public abstract class BaseEntity<TKeyType> : IHasDomainEvent
{
    protected BaseEntity(TKeyType id = default)
    {
        Id = id;
    }

    [Key]
    public TKeyType Id { get; set; }

    public IReadOnlyCollection<DomainEvent> RegisteredDomainEvents 
        => DomainEvents.AsReadOnly();

    private List<DomainEvent> DomainEvents { get; } = new ();
}