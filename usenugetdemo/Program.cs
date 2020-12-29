using System;
using mynugetdemopkg;

namespace usenugetdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(new NugetDemo().HelloWorldNugetDemo());
        }
    }
}
