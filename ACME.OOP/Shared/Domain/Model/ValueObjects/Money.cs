namespace ACME.OOP.Shared.Domain.Model.ValueObjects;

public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }
    
    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency must be a 3-letter ISO currency code.", nameof(currency));
        Amount = amount;
        Currency = currency;
    }
    
    public string AsString() => $"{Amount} {Currency}";
}
