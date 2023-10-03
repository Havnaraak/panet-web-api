using System.ComponentModel.DataAnnotations;
using PANetWebApi.Domain.Entities.Customer.Addresses;
using PANetWebApi.Domain.Enums;

namespace PANetWebApi.Domain.Entities.Customer;

public partial class Customer : BaseEntity<long>
{
    [Required]
    public string? Name { get; private set; }

    public string? CpfCnpj { get; private set; }
    
    public DateTime CreationDate { get; private set; }

    public CustomerTypeEnum Type { get; private set; }

    public IReadOnlyCollection<CustomerAddresses>? Addresses { get; private set; }
}