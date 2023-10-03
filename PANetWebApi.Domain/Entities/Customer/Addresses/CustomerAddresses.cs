using System.ComponentModel.DataAnnotations;

namespace PANetWebApi.Domain.Entities.Customer.Addresses;

public partial class CustomerAddresses : BaseEntity<long>
{
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

    public Customer Customer { get; private set; } = null!;
}