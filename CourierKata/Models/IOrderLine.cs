namespace CourierKata.Models;

public interface IOrderLine
{
    public int Cost { get; }
    public string Description { get; }
}