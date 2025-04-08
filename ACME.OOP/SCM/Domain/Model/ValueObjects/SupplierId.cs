namespace ACME.OOP.SCM.Domain.Model.ValueObjects;

public record SupplierId
{
    public string Identifier { get; init; }
    public SupplierId(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier ID cannot be null or empty.", nameof(identifier));
        Identifier = identifier;
    }
}