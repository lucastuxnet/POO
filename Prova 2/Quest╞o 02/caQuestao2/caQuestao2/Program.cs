using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new Fila();
            /* Funções */
            /*************************************************************/
            void finalizaOpcao()
            {
                Console.WriteLine();
                Console.WriteLine("Aperte Enter Para Continuar");
                Console.ReadLine();
                Console.Clear();
            }

            void insereFila()
            {
                Console.WriteLine("Digite o Numero Inteiro a Ser Inserido na Fila");
                Console.Write("Numero: ");
                int x = int.Parse(Console.ReadLine());
                fila.insere(x);
                Console.WriteLine();
            }

            void removeFila()
            {
                Console.WriteLine("Digite 's' se deseja remover um inteiro da fila e 'n' se deseja cancelar a operação");
                char x = char.Parse(Console.ReadLine());
                if (x == 's')
                {
                    fila.retirar();
                    Console.WriteLine("Inteiro Removido");
                }
                else
                {
                    Console.WriteLine("Operação Cancelada");
                }
                Console.WriteLine();
            }

            void imprimeFila()
            {
                Console.WriteLine("Os elementos atuais da fila são:");
                Console.WriteLine();
                fila.imprime();
                Console.WriteLine();
            }


            void insereApos()
            {
                Console.WriteLine("Valores que estão dentro da Fila:");
                fila.imprime();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Digite um valor que esteja dentro da fila: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o valor a ser inserido dentro da fila após o valor selecionado anteriormente: ");
                int y = int.Parse(Console.ReadLine());
                fila.insereApos(x, y);
                Console.WriteLine();
                Console.WriteLine("Fila após a inserção do elemento:");
                fila.imprime();
                Console.WriteLine();
            }


            /* Interface */
            /*************************************************************/

            while (true)
            {
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine();
                Console.WriteLine("[1] - Inserir Um Inteiro Na Fila");
                Console.WriteLine("[2] - Remover Um Inteiro Da Fila");
                Console.WriteLine("[3] - Inserir Um Inteiro Após Um Outro a Ser Escolhido");
                Console.WriteLine("[4] - Imprimir a Fila");
                Console.WriteLine("[5] - Sair");
                Console.WriteLine();
                Console.Write("Digite uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        insereFila();
                        finalizaOpcao();
                        break;

                    case 2:
                        Console.Clear();
                        removeFila();
                        finalizaOpcao();
                        break;

                    case 3:
                        Console.Clear();
                        insereApos();
                        finalizaOpcao();
                        break;

                    case 4:
                        Console.Clear();
                        imprimeFila();
                        finalizaOpcao();
                        break;

                    case 5:
                        finalizaOpcao();
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao Invalida");
                        break;
                }
            }

        }
    }
}
