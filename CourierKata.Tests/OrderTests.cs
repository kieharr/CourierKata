using CourierKata.Models;
using NUnit.Framework;

namespace CourierKata.Tests;

public class OrderTests
{
    [Test]
    public void It_should_print_the_correct_order_for_a_single_small_package()
    {
        var order = new Order();
        order.Parcels.Add(new Parcel(1,1,1));
        var actual = order.PrintOrder();
        Assert.AreEqual("Small Parcel: $3. Total Cost: $3", actual);
    }
}