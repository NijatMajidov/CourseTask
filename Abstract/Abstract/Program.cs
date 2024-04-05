
namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle areaCircle = new Circle();

            areaCircle.CalculateArea(5);

            Rectangle areaRectangle = new Rectangle();

            areaRectangle.CalculateArea(10, 21);
            
        }
    }
}
