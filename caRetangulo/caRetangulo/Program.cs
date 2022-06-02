using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {            
            ClassRetangulo r1 = new ClassRetangulo(); // criar o objeto r1 da classe Retangulo
            Console.WriteLine("Perimetro do r1 = " + r1.Perimetro());
            Console.ReadLine();
        }
    }
}
