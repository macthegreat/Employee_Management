namespace Deligates;

public delegate decimal PriceCalculator(decimal price);

public static class PriceOperations
{
    
    public static decimal ApplyDiscount(decimal price)
    {
        return price - (price * 0.1m);
    }

    public static decimal AddTax(decimal price)
    {
        return price + (price * 0.15m);
    }

    public static decimal DoublePrice(decimal price)
    {
        return price * 2;
    }
    //Func<decimal , decimal> TriplePrice = price=>price*3;
}