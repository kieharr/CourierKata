using System.Text;

namespace CourierKata.Models;

public class Order
{
    public List<Parcel> Parcels { get;  } = new ();
    private OrderTotal _total = new ();

    private bool IsCheckedOut = false;

    public void Checkout()
    {
        _total.Cost = Parcels.Sum(x => x.Cost);
        IsCheckedOut = true;
    }
    
    public string PrintOrder()
    {
        if (!IsCheckedOut)
        {
            Checkout();
        }
        
        var sb = new StringBuilder();
        foreach (var parcel in Parcels)
        {
            sb.Append($"{parcel.Description}. ");
        }
        sb.Append($"{_total.Description}");

        return sb.ToString();
    }
}