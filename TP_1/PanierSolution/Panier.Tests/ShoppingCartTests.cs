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



}
