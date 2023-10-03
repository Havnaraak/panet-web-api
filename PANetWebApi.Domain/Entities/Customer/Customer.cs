using System.ComponentModel.DataAnnotations;
using PANetWebApi.Domain.DTOs.Customer;
using PANetWebApi.Domain.Entities.Customer.Addresses;
using PANetWebApi.Domain.Enums;
using PANetWebApi.Domain.Extensions;

namespace PANetWebApi.Domain.Entities.Customer;

public partial class Customer : BaseEntity<long>
{
    public Customer()
    {
        // For entity framework
    }

    public Customer(NewCustomerDto dto)
    {
        Name = dto.Name?.Trim();
        CpfCnpj = dto.CpfCnpj?.OnlyNumbers();
        Type = dto.Type;
        
        CreationDate = DateTime.Now;
        IsActive = true;
    }
    
    [Required]
    public string? Name { get; private set; }

    public string? CpfCnpj { get; private set; }
    
    public DateTime CreationDate { get; private set; }

    [Required]
    public CustomerTypeEnum Type { get; private set; }

    public bool IsActive { get; set; }

    public IReadOnlyCollection<CustomerAddress> Addresses => _addresses.AsReadOnly();
    private readonly List<CustomerAddress> _addresses = new();
}