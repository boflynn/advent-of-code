using System;

namespace Advent.Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 265149;
            var wallLength = GetWallLength(input);
            var boxSize = (wallLength + 1) * (wallLength + 1);
            var relativePosition = GetBoxSize(wallLength) - input;

            var relativeWall = (int)Math.Floor(relativePosition / (2D * wallLength));

            var offset = relativePosition - relativeWall * 2 * wallLength;
            var stepsToMiddle = Math.Abs(offset - wallLength);

            Console.WriteLine($"Answer: {wallLength + stepsToMiddle}");
        }

        private static int GetBoxSize(int i)
        {
            return (2 * i + 1) * (2 * i + 1);
        }

        private static int GetWallLength(int input)
        {
            var size = (int)Math.Ceiling(Math.Sqrt(input));

            if (size % 2 == 1)
            {
                size--;
            }

            size = size / 2;

            return size;
        }
    }
}
