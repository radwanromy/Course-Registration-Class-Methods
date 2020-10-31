using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Triangle
    {
        {  
    public static void Main()
        {
            int x, y, z;
            Console.Write("Input side 1 of triangle: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            z = Convert.ToInt32(Console.ReadLine());



            if (x == y && y ==  z)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (x == y || x == z || y == z)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
        }
    }
}
