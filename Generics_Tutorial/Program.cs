using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine($"Has value ? {number.HasValue}");
            Console.WriteLine($"Value: { number.GetValueOrDefault()}");

            number = new Nullable<int>();
            Console.WriteLine($"Has value ? {number.HasValue}");
            Console.WriteLine($"Value: { number.GetValueOrDefault()}");

            var test = new System.Nullable<int>();
            var test2 = new int?();
        }
    }
}
