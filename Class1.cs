using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Cerchio
    {
        public double raggio { get; set; }
        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }
        public override string ToString()
        {
            return $"{raggio}";
        }
        public static Cerchio Parse (string input)
        {
            string[] dimension = input.Split(',');
            if(dimension.Length==2 && double.TryParse(dimension[0],out double raggio))
            {
                return new Cerchio(raggio);
            }
            return null;
        }
        public double Area()
        {
            return raggio * raggio;
        }
        public double Perimetro()
        {
            return 2 * 3.14 * raggio;
        }
    }
}
