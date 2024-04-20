
namespace CS162_Practice10.Apps.AreaClass
{
    internal class geometricShapes
    {
        public geometricShapes() { }
        //Changes the methods to make them overloaded, same method names, radius is the same as width.
        public static double getArea(double widthRadius, double height)
        {
            return widthRadius * height;
        }

        public static double getArea(double widthRadius)
        {
            return widthRadius * 3.14;
        }

        public static double getAreaA(double widthRadius, double height) {
            return 3.14 * (widthRadius * widthRadius) * height;
        }
    }
}
