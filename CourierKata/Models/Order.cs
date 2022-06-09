namespace CourierKata.Models;

public class Order
{
    public List<Parcel> Parcels { get; set; } = new ();

    public string PrintOrder()
    {
        throw new NotImplementedException();
    }
}