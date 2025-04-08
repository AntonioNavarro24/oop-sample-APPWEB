namespace ACME.OOP.Procurement.Domain.Model.ValueObjects;

/// <summary>
/// This value object represents a unique identifier for a product.
/// </summary>
public record ProductId
{
    public Guid Id { get; init; }
    
    /// <summary>
    /// Constructor to create a ProductId with a specific Guid.
    /// </summary>
    /// <param name="id">The unique identifier for the product.</param>
    /// <exception cref="ArgumentException">Thrown when the id is empty.</exception>
    public ProductId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Product ID cannot be empty.", nameof(id));
        Id = id;
    }
    
    /// <summary>
    /// Generates a new ProductId.
    /// </summary>
    /// <returns>A new ProductId instance with a unique identifier.</returns>
    public static ProductId New() => new(Guid.NewGuid());
}