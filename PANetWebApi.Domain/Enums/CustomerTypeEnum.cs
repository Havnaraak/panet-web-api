namespace PANetWebApi.Domain.Enums;

/// <summary>
/// Type of customers
/// </summary>
public enum CustomerTypeEnum
{
    /// <summary>
    /// Customer only
    /// </summary>
    Customer,
    
    /// <summary>
    /// Supplier only
    /// </summary>
    Supplier,
    
    /// <summary>
    /// Customer and Supplier
    /// </summary>
    CustomerSupplier,
}