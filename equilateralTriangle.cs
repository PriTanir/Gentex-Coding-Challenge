namespace GentexChallenge
{

public class equilateralTriangle: InterfaceShape
{
    public int id;
    double sideLength;
    double orientation;
    double centerX;
    double centerY;

    public equilateralTriangle(int id1, double centerX1, double centerY1, double sideLength1, double orientation1)
    {
        id=id1;
        sideLength=sideLength1;
        centerX=centerX1;
        centerY=centerY1;
        orientation=orientation1;
    }

    public double calculateArea()
    {
        return (1.732*sideLength*sideLength)/4;
    }
    public double calculatePerimeter()
    {
        return 3* sideLength;
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