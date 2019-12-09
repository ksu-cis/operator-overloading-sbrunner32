using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2, 8, 6);

            Console.WriteLine("Adding two vectors: ");
            Console.WriteLine($"With a static method: {Vector3.Add(one, two)}");
            //one.Add(two);
            Console.WriteLine($"With a class method: {one}");

            Console.WriteLine($"With operator overloading: {one + two}");

            Console.WriteLine($"With vector scaling: {10 * one}");

            Console.WriteLine($"Vector comparison: {one == two}");

            Console.WriteLine($"Vector comparison: {one == new Vector3(5, 4, 3)}");

            if(one)
            {
                Console.WriteLine("Vector one is not zero");
            }
            else
            {
                Console.WriteLine("Vector one is zero");
            }
        }
    }
}
