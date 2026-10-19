namespace Extension;
public static class StringExtensions
{
    public static string AddGreeting(this string name)
    {
      return  $"Hello, {name}!";
    }
}