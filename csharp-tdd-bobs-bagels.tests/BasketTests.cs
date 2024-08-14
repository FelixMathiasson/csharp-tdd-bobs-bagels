using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;

public class BasketTests
{
    [TestCase("Plain")]
    [TestCase("Chocolate")]
    [TestCase("Vanilla")]
    [TestCase("Strawberry")]
    [TestCase("Nutella")]
    [TestCase("Plain")]
    [TestCase("Vanilla")]
    [TestCase("Banana")]
    public void TestAddingBagel(string name)
    {
        Basket basket = new Basket();
        bool expected = basket.IsBasketFull(); //get get expected value

        bool result = basket.AddBagel(name); //see if bagel can be added

        Assert.That(expected == result);
    }





    //[TestCase("Vanilla")]
    //public void TestRemovingBagle(string name)
    //{
    //    Basket basket = new Basket();

    //}
}