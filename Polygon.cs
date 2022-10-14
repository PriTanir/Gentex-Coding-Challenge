namespace GentexChallenge
{

public class Polygon: InterfaceShape
{
    public int id;
    List<Double> xCoordinates;
    List<Double> yCoordinates;

    

    public Polygon(int id1, List<Double> xCoordinates1, List<Double> yCoordinates1)
    {
        id=id1;
       xCoordinates=xCoordinates1;
       yCoordinates=yCoordinates1;
        
    }

    public double calculateArea() //shoelace formula
    {
        int numOfVertices=xCoordinates.Count;
        double sum1=0;
        double sum2=0;
        for(int i=0;i<numOfVertices-1;i++)
        {
            sum1=sum1+xCoordinates[i]*yCoordinates[i+1];
            sum2=sum2+yCoordinates[i]*xCoordinates[i+1];
        }

        sum1=sum1+(xCoordinates[numOfVertices-1]*yCoordinates[0]);
        sum2=sum2+(xCoordinates[0]*yCoordinates[numOfVertices-1]);
        double area=(Math.Abs(sum1-sum2))/2;
        return area;

    }
    public double calculatePerimeter() //calculate lengths of sides using distance formula and add them up
    {
        List<Double> lengthsOfSides=new List<double>();
        double perimeter=0.0;
        for(int i=0;i<xCoordinates.Count-1;i++)
        {
            double x1=xCoordinates[i];
            double x2=xCoordinates[i+1];
            double y1=yCoordinates[i];
            double y2=yCoordinates[i+1];
            double xdistance=(x2-x1)*(x2-x1);
            double ydistance=(y2-y1)*(y2-y1);
            double distance=Math.Sqrt(xdistance+ydistance);
            lengthsOfSides.Add(distance);

        }
        for(int j=0;j<lengthsOfSides.Count;j++)
        {
            perimeter=perimeter+lengthsOfSides[j];
        }
        return perimeter;
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

public struct PointPolygon
{
    public double X, Y;
    public PointPolygon(double x, double y)
    {
        X=x;
        Y=y;

    }
}

}