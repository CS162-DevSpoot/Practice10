
namespace CS162_Practice10.Apps.AreaClass
{
    internal class geometricShapes
    {
        public geometricShapes() { }
        //Changes the methods to make them overloaded, same method names, radius is the same as width.

        //Circle
        public static double getArea(double widthRadius)
        {
            return (widthRadius * widthRadius) * Math.PI;
        }

        //Rectangle
        public static double getArea(double widthRadius, double height)
        {
            return widthRadius * height;
        }

        //Cylinder
        public static double getArea(double widthRadius, double height, double p) {
            return p * (widthRadius * widthRadius) * height;
        }
    }
}
