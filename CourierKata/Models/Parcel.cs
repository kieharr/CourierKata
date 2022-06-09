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

        Cost = BaseCost + OverWeightCharge(weight);
    }

    private int BaseCost => Size switch
    {
        ParcelSize.Small => 3,
        ParcelSize.Medium => 8,
        ParcelSize.Large => 15,
        ParcelSize.XL => 25,
        _ => throw new ArgumentOutOfRangeException()
    };
    
    private int OverWeightCharge (int weight) => Math.Max(0, Size switch
    {
        ParcelSize.Small => (weight - 1) * 2,
        ParcelSize.Medium => (weight - 3) * 2,
        ParcelSize.Large => (weight - 6) * 2,
        ParcelSize.XL => (weight - 10) * 2,
        _ => throw new ArgumentOutOfRangeException()
    });
}