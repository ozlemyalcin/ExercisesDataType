using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of rectangle: ");
            string lengthInput = Console.ReadLine();
            int length = int.Parse(lengthInput);

            Console.WriteLine("Enter width of rectangle: ");
            string widthInput = Console.ReadLine();
            int width = int.Parse(widthInput);

            int area = (width * length);

            Console.WriteLine("Area of rectangle: " + area);
        }
    }
}
