using System.Dynamic;
using Microsoft.VisualBasic;

namespace Linqs;

public class Productq
{
    public string Name {get;set;}
    public decimal Price{get;set;}
    public string Category{get;set;}

    public Productq(string name, decimal price, string category)
    {
        Name=name;
        Price=price;
        Category=category;
    }
    
 
}



