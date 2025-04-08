using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Model.Aggregates;

/// <summary>
/// This class represents a supplier aggregate in the bounded context of the Supply Chain Management (SCM) domain.
/// </summary>
/// <param name="identifier">The unique identifier for the supplier.</param>
/// <param name="name">The name of the supplier.</param>
/// <param name="address">The address of the supplier. See <see cref="Address"/></param>
/// <exception cref="ArgumentNullException">Thrown when any of the parameters are null.</exception>
public class Supplier(string identifier, string name, Address address)
{
    public string Identifier { get; } = identifier ?? throw new ArgumentNullException(nameof(identifier));
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
    public Address Address { get; } = address ?? throw new ArgumentNullException(nameof(address));
}