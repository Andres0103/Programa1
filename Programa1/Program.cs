using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //se llama la clase triangulo y se instancia el objeto
            Triangulo t1 = new Triangulo();

            Console.WriteLine("Digita el lado 1: ");
            t1.l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita el lado 2: ");
            t1.l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita base: ");
            t1.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita altura: ");
            t1.a = Convert.ToDouble(Console.ReadLine());

            //Instanciar el metodo

            t1.Area();
            // imprimir el atributo
            Console.WriteLine("El area es: " + t1.area.ToString());

            //aqui se invoca el metodo, pero como el metodo retorna entonces trae el valor
            Console.WriteLine("El perimetro es: " + t1.Perimetro().ToString());


            Console.ReadKey();

        }
    }
}
