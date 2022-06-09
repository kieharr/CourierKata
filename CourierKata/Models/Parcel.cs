namespace CourierKata.Models;

public class Parcel: IOrderLine
{
    public ParcelSize Size { get; private set;  }
    public int Cost { get; private set; }
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

        Cost = BaseCost(Size) + OverWeightCharge(Size, weight);
        AdjustForHeavyPackage(weight);
    }
    
    private void AdjustForHeavyPackage(int weight)
    {
        if (Cost >= 50)
        {
            var heavyCost = BaseCost(ParcelSize.Heavy) + OverWeightCharge(ParcelSize.Heavy, weight);
            if (heavyCost <= Cost)
            {
                Size = ParcelSize.Heavy;
                Cost = heavyCost;
            }
        }
    }

    private int BaseCost (ParcelSize size) => size switch
    {
        ParcelSize.Small => 3,
        ParcelSize.Medium => 8,
        ParcelSize.Large => 15,
        ParcelSize.XL => 25,
        ParcelSize.Heavy => 50,
        _ => throw new ArgumentOutOfRangeException()
    };
    
    private int OverWeightCharge (ParcelSize size, int weight) => Math.Max(0, size switch
    {
        ParcelSize.Small => (weight - 1) * 2,
        ParcelSize.Medium => (weight - 3) * 2,
        ParcelSize.Large => (weight - 6) * 2,
        ParcelSize.XL => (weight - 10) * 2,
        ParcelSize.Heavy => weight - 50,
        _ => throw new ArgumentOutOfRangeException()
    });
}