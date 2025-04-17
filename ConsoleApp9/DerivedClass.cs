using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class DerivedClass : Iinrerface //Реализует интерфейс
    {
        public void Method()
        {
            Console.WriteLine("Метод Method,  реал-й в классе DerivedClass");
        }
    }
}
