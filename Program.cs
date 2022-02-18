using System;

using static KeLi.RandomMap.Properties.Resources;

namespace KeLi.RandomMap
{
    internal class Program
    {
        private static void Main()
        {
            const int width = 30;
            const int height = 30;

            Console.Title = _RandomMap;
            Console.WindowWidth = width * 2 + 1;
            Console.WindowHeight = height + 1;

            var map = new Map(width, height);

            map.Create();
            map.Render();

            Console.ReadKey();
        }
    }
}