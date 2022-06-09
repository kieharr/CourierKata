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

    [Test]
    public void A_small_parcel_should_cost_3()
    {
        var parcel = new Parcel(1, 1, 1);
        var actual = parcel.Cost;
        Assert.AreEqual(3, actual);
    }
    
    [Test]
    public void A_medium_parcel_should_cost_8()
    {
        var parcel = new Parcel(10, 10, 10);
        var actual = parcel.Cost;
        Assert.AreEqual(8, actual);
    }  
    
    [Test]
    public void A_large_parcel_should_cost_15()
    {
        var parcel = new Parcel(50, 50, 50);
        var actual = parcel.Cost;
        Assert.AreEqual(15, actual);
    } 
    
    [Test]
    public void An_XL_parcel_should_cost_25()
    {
        var parcel = new Parcel(100, 100, 100);
        var actual = parcel.Cost;
        Assert.AreEqual(25, actual);
    }
    
    
}