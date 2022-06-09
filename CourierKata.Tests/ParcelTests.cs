using System.Diagnostics;
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
}