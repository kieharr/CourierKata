namespace CourierKata.Models;

public class Parcel
{
    public ParcelSize Size { get; set; }
    public Parcel(int height, int width, int length)
    {
        Size = Math.Max(height, Math.Max(width, length)) switch
        {
            < 10 => ParcelSize.Small,
            _ => throw new NotImplementedException()
        };
    }
}