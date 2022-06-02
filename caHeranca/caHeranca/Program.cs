using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de Heranca");

            Empregado e1 = new Empregado("Joao", "Contabilidade", 1000.0);

            Gerente g1 = new Gerente("Jose", "Almoxarifado", 1000.0, "Maria");
                       
            Console.WriteLine("Nome do Gerente: " + g1.getNome());
            Console.WriteLine("Nome da Secretaria: " + g1.getSecretaria());
            Console.WriteLine("\n Salario ANTES do Empregado: ", +e1.getSalario());
            Console.WriteLine(" Salario ANTES do Gerente: " + g1.getSalario());
            e1.aumentaSalario(30.0);
            g1.aumentaSalario(30.0);
            Console.WriteLine("\n Salario DEPOIS do Empregado: " + e1.getSalario());
            Console.WriteLine(" Salario DEPOIS do Gerente: " + g1.getSalario());
            Console.Read();


        }
    }
}
