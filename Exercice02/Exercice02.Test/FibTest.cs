namespace Exercice02.Test;

[TestClass]
public class FibTest
{
    private Fib _fib;

    public void Setup(int range)
    {
        _fib = new Fib(range);
    }


    [TestMethod]
    public void WhenGetFibSeries_WhithRange1_Then_NotEmpty()
    {
        Setup(1);
        var result = _fib.GetFibSeries();
        Assert.IsNotEmpty(result);
    }

    [TestMethod]
    public void WhenGetFibSeries_WhithRange1_Contains0()
    {
        Setup(1);
        var result = _fib.GetFibSeries();
        CollectionAssert.Contains(result, 0);
        // CollectionAssert.AreEquivalent(result, new List<int> { 0 });
    }


    [TestMethod]
    public void WhenGetFibSeries_WhithRange6_Contains3()
    {
        Setup(6);
        var result = _fib.GetFibSeries();
        CollectionAssert.Contains(result, 3);
    }

    [TestMethod]
    public void WhenGetFibSeries_WhithRange6_ContainsSixElements()
    {
        Setup(6);
        var result = _fib.GetFibSeries();
        Assert.HasCount(6, result);
    }

    [TestMethod]
    public void WhenGetFibSeries_WhithRange6_DoesNotContain4()
    {
        Setup(6);
        var result = _fib.GetFibSeries();
        CollectionAssert.DoesNotContain(result, 4);
    }

    [TestMethod]
    public void WhenGetFibSeries_WhithRange6_EquivalentTo()
    {
        Setup(6);
        var result = _fib.GetFibSeries();
        CollectionAssert.AreEquivalent(result, new List<int>{ 0, 1, 1, 2, 3, 5 });
    }

    [TestMethod]
    public void WhenGetFibSeries_WhithRange6_IsSorted()
    {
        Setup(6);
        var result = _fib.GetFibSeries();
        var clone = new List<int>(result);
        clone.Sort();
        CollectionAssert.AreEquivalent(result, clone);
    }

}
