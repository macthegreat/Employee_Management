namespace structs;
public struct Rectangles
{
    public double Width{get; set;}
    public double Height{get;set;}

    public Rectangles(double width, double height)
    {
        Width =width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width*Height;
    }

    public double calculatePerimeter()
    {
        return 2*(Width + Height);
    }
}