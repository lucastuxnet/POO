using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class ClassRetangulo
    { 
        // Atributos (Obs sempre letra minuscula)

        private double basis;
        private double altura;

        // métodos (Obs começa com minuscula e continua maiuscula)
        
        public double Perimetro()
        {
            return (2 * (basis + altura));
        }

        public double Area()
        {
            return((basis * altura))
        }

    } // fim da classe Retangulo
}
