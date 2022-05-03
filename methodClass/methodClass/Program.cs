using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMethod voidmethod = new voidMethod();
            int j = 5;
            int p = 100;

            voidmethod.methodOne(j, p);
            Console.ReadLine();
        }
    }
}
