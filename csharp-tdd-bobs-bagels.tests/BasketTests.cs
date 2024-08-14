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





    [TestCase("Vanilla")]
    [TestCase("Chocolate")]
    [TestCase("Tarzan")]
    [TestCase("Banana")]
    [TestCase("Vanilla")]
    [TestCase("Plain")]
    [TestCase("Banana")]
    public void TestRemovingBagle(string name)
    {
        Basket basket = new Basket();

        //adding two bagels so code can test to remove 
        //existent and non-existent bagels
        basket.AddBagel("Plain");
        basket.AddBagel("Banana");

        bool expected = basket.DoesBagelExist(name); 

        bool result = basket.RemoveBagel(name);

        Assert.That(expected == result);
    }



    [TestCase(5)]
    public void TestChangingBasketSize(int size)
    {
        Basket basket = new Basket();

        //adding two bagels so code can test to change
        //basket size below the bagelamount
        basket.AddBagel("Plain");
        basket.AddBagel("Banana");

        bool expected = basket.CanSizeBeChanged(size);

        bool result = basket.ChangeBasketSize(size);

        Assert.That(expected == result);
    }
}