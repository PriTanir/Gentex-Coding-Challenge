namespace GentexChallenge
{

public class Ellipse: InterfaceShape
{
    public int id;
    double r1;

    double r2;

    double orientation;
    double centerX;
    double centerY;

    

    public Ellipse(int id1, double centerX1, double centerY1, double r11, double r21, double orientation1)
    {
        id=id1;
        r1=r11;
        centerX=centerX1;
        centerY=centerY1;
        orientation=orientation1;
        r2=r21;
        
    }

    public double calculateArea()
    {
        return 3.14*r1*r2;
    }
    public double calculatePerimeter()
    {
        double h=((r1-r2)*(r1-r2))/((r1+r2)*(r1+r2));
        return (3.14*(r1+r2))*((3*h)/(10+Math.Sqrt(4-(3*h))));
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