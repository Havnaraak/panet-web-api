using PANetWebApi.Domain.DTOs.Customer.Address;
using PANetWebApi.Domain.Entities.Customer.Addresses;
using PANetWebApi.Domain.Enums;
using PANetWebApi.Domain.Events;
using PANetWebApi.Domain.Extensions;

namespace PANetWebApi.Domain.Entities.Customer;

public partial class Customer
{
    public void UpdateBasicDetails(string name, string cpfCnpj)
    {
        Name = name;
        CpfCnpj = cpfCnpj.OnlyNumbers();
        
        DomainEvents.Add(new AlteredCustomerEvent(this));
    }

    public void EditType(CustomerTypeEnum typeEnum)
    {
        Type = typeEnum;
        
        DomainEvents.Add(new AlteredCustomerEvent(this));
    }

    public void InactiveCustomer()
    {
        IsActive = false;
        
        DomainEvents.Add(new AlteredCustomerEvent(this));
    }

    public void ActiveCustomer()
    {
        IsActive = true;
        
        DomainEvents.Add(new AlteredCustomerEvent(this));
    }
    
    public void AddAddress(NewAddressDto dto)
    {
        _addresses.Add(new CustomerAddress(dto));
        
        DomainEvents.Add(new AlteredCustomerEvent(this));
    }
}