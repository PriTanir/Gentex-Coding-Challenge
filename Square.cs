namespace GentexChallenge
{

public class Square: InterfaceShape
{
    public int id;
    double sideLength;
    double centerX;
    double centerY;

    double orientation;

    public Square(int id1, double centerX1, double centerY1, double sideLength1, double orientation1)
    {
        id=id1;
        sideLength=sideLength1;
        centerX=centerX1;
        centerY=centerY1;
        orientation=orientation1;
        
    }

    public double calculateArea()
    {
        return sideLength*sideLength;
    }
    public double calculatePerimeter()
    {
        return 4 * sideLength;
    }
    public double calculateCentroidX()
    {
        return 0;
    }

    public double calculateCentroidY()
    {
        return 0;
    }
}
}