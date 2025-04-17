using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"метод, возвращающий число типа int: { myClass.MyGetInt()}");
            Console.WriteLine($"метод, возвращающий число PI: {myClass.MyGetPi()}"); 
            Console.WriteLine($"метод, возвращающий x в квадрате: {myClass.MySquare(3)}");
            Console.WriteLine($"метод, возвращающий корень квадратный из x: {myClass.MySqrt(5)}");
            Console.Read();
        }
    }
}
