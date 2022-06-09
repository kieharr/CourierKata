namespace CourierKata.Models;

public class Parcel: IOrderLine
{
    public ParcelSize Size { get; }
    public int Cost { get; }
    public string Description => $"{Size} Parcel: ${Cost}";

    public Parcel(int width, int length, int height, int weight)
    {
        Size = Math.Max(height, Math.Max(width, length)) switch
        {
            < 10 => ParcelSize.Small,
            < 50 => ParcelSize.Medium,
            < 100 => ParcelSize.Large,
            _ => ParcelSize.XL
        };

        Cost = Size switch
        {
            ParcelSize.Small => 3,
            ParcelSize.Medium => 8,
            ParcelSize.Large => 15,
            ParcelSize.XL => 25,
            _ => throw new ArgumentOutOfRangeException()
        };

    }
}