using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
            derivedClass.Method2();
            derivedClass.Method3();
            Console.WriteLine();
            IInterface2 dClass = derivedClass;
            derivedClass.Method1();
            derivedClass.Method2();
            derivedClass.Method3();
            Console.Read();
        }
    }
}
