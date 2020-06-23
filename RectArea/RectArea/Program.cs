using System;

namespace RectArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the rectangle?");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
