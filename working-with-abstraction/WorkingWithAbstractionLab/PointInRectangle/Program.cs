using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var topLeftPoint = new Point(input[0], input[1]);
            var bottomRightPoint = new Point(input[2], input[3]);
            var rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            int pointsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointsCount; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Point currentPoint = new Point(pointCoordinates[0], pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }
}
