namespace Pr14_PointInFigure
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            int firstRectangleX1 = 0*h;
            int firstRectangleY1 = 0*h;
            int firstRectangleX2 = 3*h;
            int firstRectangleY2 = 1*h;

            int secondRectangleX1 = 1*h;
            int secondRectangleY1 = 1*h;
            int secondRectangleX2 = 2*h;
            int secondRectangleY2 = 4*h;

            int lineX1 = h*1;
            int lineX2 = h*2;
            int lineY = h*1;
            bool isOnTheLine = 
                pointY == lineY &&
                (pointX > lineX1 && pointX < lineX2);

            if (isOnTheLine)
            {
                Console.WriteLine("inside");
                return;
            }

            bool isInsideFirstRectangle =
                (pointX > firstRectangleX1 && pointX < firstRectangleX2) &&
                (pointY > firstRectangleY1 && pointY < firstRectangleY2);

            bool isInsideSecondRectangle =
                (pointX > secondRectangleX1 && pointX < secondRectangleX2) &&
                (pointY > secondRectangleY1 && pointY < secondRectangleY2);
            
            bool isOutsideFirstRectangle =
                (pointX < firstRectangleX1 || pointX > firstRectangleX2) ||
                (pointY < firstRectangleY1 || pointY > firstRectangleY2);

            bool isOutsideSecondRectangle =
                (pointX < secondRectangleX1 || pointX > secondRectangleX2) ||
                (pointY < secondRectangleY1 || pointY > secondRectangleY2);

            if (isInsideFirstRectangle || isInsideSecondRectangle)
            {
                Console.WriteLine("inside");
            }
            else if (isOutsideFirstRectangle && isOutsideSecondRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}