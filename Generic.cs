using System.ComponentModel.DataAnnotations;

namespace Generics;

class Storage<TValue>
{
    public TValue First { get; set; }


    public Storage(TValue value)
    {
        First = value;
      
    }

    public static void Display<T>(T value){
        Console.WriteLine(value);
    }
   
}



