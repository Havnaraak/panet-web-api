using PANetWebApi.Domain.Common;
using PANetWebApi.Domain.Entities.Customer;

namespace PANetWebApi.Domain.Events;

public class AlteredCustomerEvent : DomainEvent
{
    public AlteredCustomerEvent(Customer alteredCustomer)
    {
        AlteredCustomer = alteredCustomer;
    }

    public Customer AlteredCustomer { get; }
}