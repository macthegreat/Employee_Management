
namespace Lambdas;

public delegate decimal PriceCalculate(decimal price);
 
public static class Prog
{
    public static Func<decimal ,decimal> Discount =price =>price * 0.9m;
    public static Func<decimal, decimal> AddTax = price => price + (price*0.15m);
    public static Func<decimal,decimal> DoublePrice = price => price*2;

    public static Func<decimal ,decimal, decimal> AddPrice=(price1,price2)=>price2+price1;
    }


