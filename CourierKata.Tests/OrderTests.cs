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
    
    [Test]
    public void It_should_print_the_correct_order_for_a_single_medium_package()
    {
        var order = new Order();
        order.Parcels.Add(new Parcel(10,10,10));
        var actual = order.PrintOrder();
        Assert.AreEqual("Medium Parcel: $8. Total Cost: $8", actual);
    }
    
    [Test]
    public void It_should_print_the_correct_order_for_a_single_large_package()
    {
        var order = new Order();
        order.Parcels.Add(new Parcel(50,50,50));
        var actual = order.PrintOrder();
        Assert.AreEqual("Large Parcel: $15. Total Cost: $15", actual);
    }    
    
    [Test]
    public void It_should_print_the_correct_order_for_a_single_xl_package()
    {
        var order = new Order();
        order.Parcels.Add(new Parcel(100,100,100));
        var actual = order.PrintOrder();
        Assert.AreEqual("XL Parcel: $25. Total Cost: $25", actual);
    } 
    
    [Test]
    public void Speedy_shipping_for_small_package_should_double_the_cost_to_6()
    {
        var order = new Order();
        order.Parcels.Add(new Parcel(1,1,1));
        order.SpeedyShipping = true;
        order.Checkout();

        var actualCost = order.Total;
        Assert.AreEqual(6, actualCost);
    }
}