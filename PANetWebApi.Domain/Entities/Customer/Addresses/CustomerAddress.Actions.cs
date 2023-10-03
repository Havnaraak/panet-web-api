using PANetWebApi.Domain.DTOs.Customer.Address;

namespace PANetWebApi.Domain.Entities.Customer.Addresses;

public partial class CustomerAddress
{
    public void UpdateBasicDetails(NewAddressDto dto)
    {
        Street = dto.Street?.Trim();
        ZipCode = dto.ZipCode?.Trim();
        District = dto.District?.Trim();
        Number = dto.Number;
        City = dto.City?.Trim();
        Country = dto.Country?.Trim();
    }

    public void SetMainAddress()
    {
        IsMain = true;
    }

    public void ResetMainAddress()
    {
        IsMain = false;
    }

    public void InactiveAddress()
    {
        IsActive = false;
    }

    public void ActiveAddress()
    {
        IsActive = true;
    }
}