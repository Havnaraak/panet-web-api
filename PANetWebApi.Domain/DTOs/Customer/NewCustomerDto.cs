using PANetWebApi.Domain.Enums;

namespace PANetWebApi.Domain.DTOs.Customer;

public class NewCustomerDto
{
    public string? Name { get;  set; }

    public string? CpfCnpj { get;  set; }
    
    public CustomerTypeEnum Type { get;  set; }
}