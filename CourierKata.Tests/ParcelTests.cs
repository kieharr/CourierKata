using CourierKata.Models;
using NUnit.Framework;

namespace CourierKata.Tests;

public class ParcelTests
{
    [TestCase(1,1,1)]
    [TestCase(9,9,9)]
    public void It_should_be_a_small_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(width, length, height, 0);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.Small, actual);
    }

    [TestCase(10,1,1)]
    [TestCase(9,10,9)]
    [TestCase(9,10,49)]
    public void It_should_be_a_medium_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(width, length, height, 0);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.Medium, actual);
    }
    
    [TestCase(50,1,1)]
    [TestCase(9,50,9)]
    [TestCase(9,10,50)]
    [TestCase(9,10,99)]
    public void It_should_be_a_large_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(width, length, height, 0);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.Large, actual);
    }   
    
    [TestCase(100,1,1)]
    [TestCase(9,100,9)]
    [TestCase(9,10,100)]
    [TestCase(9,10,500)]
    public void It_should_be_an_xl_parcel(int height, int width, int length)
    {
        var parcel = new Parcel(width, length, height, 0);
        var actual = parcel.Size;
        Assert.AreEqual(ParcelSize.XL, actual);
    }

    [Test]
    public void A_small_parcel_should_cost_3()
    {
        var parcel = new Parcel(1, 1, 1, 0);
        var actual = parcel.Cost;
        Assert.AreEqual(3, actual);
    }
    
    [Test]
    public void A_medium_parcel_should_cost_8()
    {
        var parcel = new Parcel(10, 10, 10, 0);
        var actual = parcel.Cost;
        Assert.AreEqual(8, actual);
    }  
    
    [Test]
    public void A_large_parcel_should_cost_15()
    {
        var parcel = new Parcel(50, 50, 50, 0);
        var actual = parcel.Cost;
        Assert.AreEqual(15, actual);
    } 
    
    [Test]
    public void An_XL_parcel_should_cost_25()
    {
        var parcel = new Parcel(100, 100, 100, 0);
        var actual = parcel.Cost;
        Assert.AreEqual(25, actual);
    }
    
    [TestCase(1, 3)]
    [TestCase(2, 5)]
    [TestCase(3, 7)]
    public void A_small_parcel_should_have_the_correct_overweight_charge(int weight, int expectedCost)
    {
        var parcel = new Parcel(1, 1, 1, weight);
        var actual = parcel.Cost;
        Assert.AreEqual(expectedCost, actual);
    }    
    
    [TestCase(3, 8)]
    [TestCase(4, 10)]
    [TestCase(5, 12)]
    public void A_medium_parcel_should_have_the_correct_overweight_charge(int weight, int expectedCost)
    {
        var parcel = new Parcel(11, 11, 11, weight);
        var actual = parcel.Cost;
        Assert.AreEqual(expectedCost, actual);
    }    
    
    [TestCase(6, 15)]
    [TestCase(7, 17)]
    [TestCase(8, 19)]
    public void A_large_parcel_should_have_the_correct_overweight_charge(int weight, int expectedCost)
    {
        var parcel = new Parcel(50, 50, 50, weight);
        var actual = parcel.Cost;
        Assert.AreEqual(expectedCost, actual);
    } 
    
    [TestCase(10, 25)]
    [TestCase(11, 27)]
    [TestCase(12, 29)]
    public void An_XL_parcel_should_have_the_correct_overweight_charge(int weight, int expectedCost)
    {
        var parcel = new Parcel(100, 100, 100, weight);
        var actual = parcel.Cost;
        Assert.AreEqual(expectedCost, actual);
    }
}