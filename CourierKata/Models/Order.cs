using System.Text;

namespace CourierKata.Models;

public class Order
{
    public List<Parcel> Parcels { get;  } = new ();

    public string PrintOrder()
    {
        var sb = new StringBuilder();
        foreach (var parcel in Parcels)
        {
            sb.Append($"{parcel.Size} Parcel: ${parcel.Cost}. ");
        }

        var totalCost = Parcels.Sum(x => x.Cost);
        sb.Append($"Total Cost: ${totalCost}");

        return sb.ToString();
    }
}