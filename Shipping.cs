namespace Shipping;

public class Shippings
{
    public virtual decimal CalculateCost(decimal weight)
    {
        return 0;
    } 
}

public class StandardShipping : Shippings
{
    public override decimal CalculateCost(decimal weight)
    {
        return weight * 10;
    }
}
public class ExpressShipping : Shippings
{
    public override decimal CalculateCost(decimal weight)
    {
        return weight * 20 + 100;
    }
}
public class InternationalShipping : Shippings
{
    public override decimal CalculateCost(decimal weight)
    {
        return weight * 50 + 500;
    }
}