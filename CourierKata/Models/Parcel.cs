namespace CourierKata.Models;

public class Parcel
{
    public ParcelSize Size { get; }
    public int Cost { get; set; }
    
    public Parcel(int height, int width, int length)
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