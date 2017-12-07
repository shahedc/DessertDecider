using System;
using Tester.Utils;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ApiCaller.GetNumericPoints().ToString());
            Console.WriteLine(ApiCaller.GetBoolDecision().ToString());


            Console.ReadKey();
        }
    }
}
