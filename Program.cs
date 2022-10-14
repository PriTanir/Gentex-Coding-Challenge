
namespace GentexChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"output.txt";


            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Id,Area,Perimeter,CentroidX,CentroidY");
            using (var reader = new StreamReader(@"Shapes-49464.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    switch (values[1])
                    {
                        case "Circle":
                            {
                                Circle myCircle = new Circle(Int32.Parse(values[0]), Double.Parse(values[3]), Double.Parse(values[5]), Double.Parse(values[7]));
                                writer.Write(myCircle.id + ",");
                                writer.Write(myCircle.calculateArea() + ",");
                                writer.Write(myCircle.calculatePerimeter() + ",");
                                writer.Write(myCircle.calculateCentroidX() + ",");
                                writer.Write(myCircle.calculateCentroidY());
                                writer.WriteLine();
                                break;
                            }
                        case "Square":
                            {
                                Square mySquare = new Square(Int32.Parse(values[0]), Double.Parse(values[3]), Double.Parse(values[5]), Double.Parse(values[7]), Double.Parse(values[9]));
                                writer.Write(mySquare.id + ",");
                                writer.Write(mySquare.calculateArea() + ",");
                                writer.Write(mySquare.calculatePerimeter() + ",");
                                writer.Write(mySquare.calculateCentroidX() + ",");
                                writer.Write(mySquare.calculateCentroidY());
                                writer.WriteLine();
                                break;
                            }
                        case "Equilateral Triangle":
                            {
                                equilateralTriangle triangle = new equilateralTriangle(Int32.Parse(values[0]), Double.Parse(values[3]), Double.Parse(values[5]), Double.Parse(values[7]), Double.Parse(values[9]));
                                writer.Write(triangle.id + ",");
                                writer.Write(triangle.calculateArea() + ",");
                                writer.Write(triangle.calculatePerimeter() + ",");
                                writer.Write(triangle.calculateCentroidX() + ",");
                                writer.Write(triangle.calculateCentroidY());
                                writer.WriteLine();
                                break;
                            }
                        case "Ellipse":
                            {
                                Ellipse myEllipse = new Ellipse(Int32.Parse(values[0]), Double.Parse(values[3]), Double.Parse(values[5]), Double.Parse(values[7]), Double.Parse(values[9]), Double.Parse(values[11]));
                                writer.Write(myEllipse.id + ",");
                                writer.Write(myEllipse.calculateArea() + ",");
                                writer.Write(myEllipse.calculatePerimeter() + ",");
                                writer.Write(myEllipse.calculateCentroidX() + ",");
                                writer.Write(myEllipse.calculateCentroidY());
                                writer.WriteLine();
                                break;
                            }
                        case "Polygon":
                            {
                                List<Double> xCoordinates = new List<double>();
                                List<Double> yCoordinates = new List<double>();

                                for(int i=values.Length-3;i>=3;i=i-4) //fill up xCordinates in reverse order for shoelace
                                {
                                    xCoordinates.Add(Double.Parse(values[i]));
                                }
                                for(int j=values.Length-1;j>=5;j=j-4) //fill up xCordinates
                                {
                                    yCoordinates.Add(Double.Parse(values[j]));
                                }
                                Polygon myPolygon = new Polygon(Int32.Parse(values[0]), xCoordinates, yCoordinates);
                                writer.Write(myPolygon.id + ",");
                                writer.Write(myPolygon.calculateArea() + ",");
                                writer.Write(myPolygon.calculatePerimeter() + ",");
                                writer.Write(myPolygon.calculateCentroidX() + ",");
                                writer.Write(myPolygon.calculateCentroidY());
                                writer.WriteLine();
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("This shape is new! Create a new class for it! The ID and Shape are " + values[0] + " " + values[1]);
                                break;
                            }
                    }


                }


            }
        }


        }
    }
}
