using CourierKata.Models;
using NUnit.Framework;

namespace CourierKata.Tests;

public class ParcelTests
{
    [TestCase(1,1,1)]
    [TestCase(9,9,9)]
    public void It_should_be_a_small_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(height, width, length);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.Small, actual);
    }

    [TestCase(10,1,1)]
    [TestCase(9,10,9)]
    [TestCase(9,10,49)]
    public void It_should_be_a_medium_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(height, width, length);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.Medium, actual);
    }
    
    [TestCase(50,1,1)]
    [TestCase(9,50,9)]
    [TestCase(9,10,50)]
    [TestCase(9,10,99)]
    public void It_should_be_a_large_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(height, width, length);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.Large, actual);
    }   
    
    [TestCase(100,1,1)]
    [TestCase(9,100,9)]
    [TestCase(9,10,100)]
    [TestCase(9,10,500)]
    public void It_should_be_an_xl_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(height, width, length);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.XL, actual);
    }
}