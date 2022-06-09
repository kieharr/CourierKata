using System.Text;

namespace CourierKata.Models;

public class Order
{
    public List<Parcel> Parcels { get;  } = new ();
    public bool SpeedyShipping { get; set; }
    public OrderTotal Total { get; } = new ();

    private bool _isCheckedOut;

    public void Checkout()
    {
        Total.Cost = Parcels.Sum(x => x.Cost);
        if (SpeedyShipping)
        {
            Total.Cost *= 2;
        }
        _isCheckedOut = true;
    }
    
    public string PrintOrder()
    {
        if (!_isCheckedOut)
        {
            Checkout();
        }
        
        var sb = new StringBuilder();
        foreach (var parcel in Parcels)
        {
            sb.Append($"{parcel.Description}. ");
        }
        sb.Append($"{Total.Description}");

        return sb.ToString();
    }
}