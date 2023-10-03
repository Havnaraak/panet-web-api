namespace PANetWebApi.Domain.DTOs.Customer.Address;

public class NewAddressDto
{
    public long CustomerId { get; set; }
    
    public string? Street { get; set; }
    
    public string? ZipCode { get; set; }
    
    public string? District { get; set; }
    
    public long Number { get; set; }
    
    public string? City { get; set; }
    
    public string? Country { get; set; }
}