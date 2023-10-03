using System.ComponentModel.DataAnnotations;
using PANetWebApi.Domain.DTOs.Customer.Address;

namespace PANetWebApi.Domain.Entities.Customer.Addresses;

public partial class CustomerAddress : BaseEntity<long>
{
    public CustomerAddress()
    {
        // For entity framework
    }
    
    public CustomerAddress(NewAddressDto dto)
    {
        CustomerId = dto.CustomerId;
        
        Street = dto.Street?.Trim();
        ZipCode = dto.ZipCode?.Trim();
        District = dto.District?.Trim();
        Number = dto.Number;
        City = dto.City?.Trim();
        Country = dto.Country?.Trim();

        IsActive = true;
    }
    
    [Required]
    public long CustomerId { get; private set; }
    
    [Required]
    public string? Street { get; private set; }
    
    public string? ZipCode { get; private set; }
    
    [Required]
    public string? District { get; private set; }
    
    [Required]
    public long Number { get; private set; }
    
    [Required]
    public string? City { get; private set; }
    
    [Required]
    public string? Country { get; private set; }

    public bool IsActive { get; private set; }

    public bool IsMain { get; private set; }

    public Customer Customer { get; private set; } = null!;
}