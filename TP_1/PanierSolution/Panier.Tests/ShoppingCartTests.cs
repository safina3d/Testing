using Panier.Core;

namespace Panier.Tests;

[TestClass]
public class ShoppingCartTests
{
    private ShoppingCart _shoppingCart;

    private void Setup()
    {
        _shoppingCart = new ShoppingCart();
    }
    

    [TestMethod]
    public void WhenGetItemCountIsCreated_ThenShoppingCartIsEmpty()
    {
        Setup();
        Assert.AreEqual(0, _shoppingCart.GetItemCount());
    }


    [TestMethod]
    public void WhenGetTotal_ThenTotalIsZero()
    {
        Setup();
        Assert.AreEqual(0, _shoppingCart.GetTotal());
    }

    [TestMethod]
    public void WhenApplyDiscount_OnEmptyCart_ThenThrowsException()
    {
        Setup();
        Assert.Throws<ArgumentException>(() => _shoppingCart.ApplyDiscount(0.05m));
    }


    [TestMethod]
    public void WhenAddItem_WithValidItem_ThenItemCountIsUp()
    {
        Setup();
        int before = _shoppingCart.GetItemCount();
        _shoppingCart.AddItem("RAM", 999m, 2);
        Assert.AreEqual(before + 1, _shoppingCart.GetItemCount());
    }

    [TestMethod]
    public void WhenAddItem_WithNullName_ThenItThrowsException()
    {
        Setup();
        Assert.Throws<ArgumentNullException>(() => _shoppingCart.AddItem(null, 999m, 2));
    }

    [TestMethod]
    public void WhenAddItem_WithNegativePrice_ThenItThrowsException()
    {
        Setup();
        Assert.Throws<ArgumentException>(() => _shoppingCart.AddItem("PC", -2.0m, 1));
    }

    [TestMethod]
    public void WhenAddItem_WithNegativeQuantity_ThenItThrowsException()
    {
        Setup();
        Assert.Throws<ArgumentException>(() => _shoppingCart.AddItem("PC", 999m, -3));
    }



}
