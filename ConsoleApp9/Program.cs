using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            Console.WriteLine();
            Iinrerface myInrerface = derivedClass;
            myInrerface.Method();
            Console.Read();
        }
    }
}
