using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio (5);
            Cerchio r =Cerchio.Parse(c.ToString());
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
