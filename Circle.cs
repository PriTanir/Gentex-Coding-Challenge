namespace GentexChallenge
{

public class Circle: InterfaceShape
{
    public int id;
    double radius;
    double centerX;
    double centerY;

    public Circle(int id1, double centerX1, double centerY1, double radius1)
    {
        id=id1;
        radius=radius1;
        centerX=centerX1;
        centerY=centerY1;
        
    }

    public double calculateArea()
    {
        return 3.14*radius*radius;
    }
    public double calculatePerimeter()
    {
        return 2* 3.14 * radius;
    }
    public double calculateCentroidX()
    {
        return centerX;
    }

    public double calculateCentroidY()
    {
        return centerY;
    }
}
}