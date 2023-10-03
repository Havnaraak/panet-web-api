namespace PANetWebApi.Domain.Common;

public abstract class DomainEvent
{
    protected DomainEvent()
    {
        DateOccurred = DateTimeOffset.UtcNow;
    }

    public DateTimeOffset DateOccurred { get; }

    public bool IsPublished { get; private set; }

    public void MarkAsProcessed()
    {
        IsPublished = true;
    }
}