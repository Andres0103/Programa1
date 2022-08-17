using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Triangulo
    {
        //declara variables con get y ser
        public double l1 { get; set; }
        public double l2 { get; set; }
        public double b { get; set; }
        public double a { get; set; }
        public double area {get; set;}

        //se declara el metodo constructor
       public Triangulo()
        {
            l1 = 0;
            l2 = 0;
            b = 0;
            a = 0;

        }

        // se crea el metodo Area, de tipo void porque no va a retornar.
        public void Area()
        {
            area = b * a / 2;
        }

        // metodo para hayar perimetro
        public double Perimetro()
        {
            return l1 + l2 + b;
        }
    }
}
