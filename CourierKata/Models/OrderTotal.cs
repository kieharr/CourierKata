namespace CourierKata.Models;

public class OrderTotal: IOrderLine
{
    public int Cost { get; set; }
    public string Description => $"Total Cost: ${Cost}";
    
}