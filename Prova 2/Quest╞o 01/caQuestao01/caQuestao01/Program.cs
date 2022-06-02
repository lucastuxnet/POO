using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao01
{
    class Program
    {
        private static Pilha<Container>[] pilhas = new Pilha<Container>[4];
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                pilhas[i] = new Pilha<Container>(3);
            }
            bool end = false;
            do
            {
                Console.Clear();
                PrintContainers();
                Console.Write("Escolha:\n1.Adicionar Container;\n2. Remover Container;\n3.Sair\n");
                string input = Console.ReadLine();
                int _in = 0;
                int.TryParse(input, out _in);

                switch (_in)
                {
                    case 1:
                        int _min = 4;
                        int j = 0;
                        int id = 0;
                        string c_id_S = "";
                        Console.Write("Codigo do container:");
                        c_id_S = Console.ReadLine();
                        if (int.TryParse(c_id_S, out id))
                        {
                            bool con = true;
                            for (int i = 0; i < 4; i++)
                            {
                                int k = 0;
                                foreach (Container c in pilhas[i].Items)
                                {
                                    if (pilhas[i].Count > k)
                                        if (c != null)
                                        {
                                            if (c.id == id)
                                            {
                                                con = false;
                                                break;
                                            }
                                        }
                                    k++;
                                }
                                if (pilhas[i].Count < _min)
                                {
                                    _min = pilhas[i].Count;
                                    j = i;
                                }
                            }
                            if (!con)
                            {
                                Console.Write("Codigo invalido. (Codigo ja existente)");
                                Console.ReadLine();
                                break;
                            }
                            bool ans = pilhas[j].Add(new Container(id));
                            if (!ans)
                            {
                                Console.Write("Impossivel empilhar. (Nao ha espaco)");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            Console.Write("Codigo invalido. (Deve ser um numero inteiro)");
                            Console.ReadLine();
                            break;
                        }
                        break;
                    case 2:
                        int pilha_index = 0;
                        int pos = 0;
                        Console.Write("Codigo do container:");
                        c_id_S = Console.ReadLine();
                        if (int.TryParse(c_id_S, out id))
                        {
                            bool exists = false;
                            for (int i = 0; i < 4; i++)
                            {
                                int count = 0;
                                foreach (Container c in pilhas[i].Items)
                                {
                                    if (c != null)
                                    {
                                        if (c.id == id)
                                        {
                                            exists = true;
                                            pos = count;
                                            pilha_index = i;
                                            break;
                                        }
                                    }
                                    count++;
                                }
                            }
                            if (exists && pos == pilhas[pilha_index].Count - 1)
                            {
                                pilhas[pilha_index].Pop();
                            }
                            else
                            {
                                if (!exists)
                                    Console.Write("Impossivel remover. (Conatiner nao existe)");
                                else
                                    Console.Write("Impossivel remover. (Conatiner nao esta no topo)");
                                Console.ReadLine();
                                break;
                            }
                        }
                        break;
                    case 3:
                        end = true;
                        break;
                    default:
                        Console.Write("Entrada invalida.");
                        Console.ReadLine();
                        break;
                }

                if (end)
                    break;

            } while (true);
        }

        static void PrintContainers()
        {
            string s = "|C1| |C2| |C3| |C4|\n";
            string[] st = new string[3];
            string _end = "-------------------\n\n";
            int[] counts = new int[4];
            for (int i = 0; i < 4; i++)
            {
                counts[i] = pilhas[i].Count;
            }

            for (int i = 2; i >= 0; i--)
            {
                st[i] += counts[0] >= i + 1 ? string.Format("|{0}| ", pilhas[0].Item(i).id) : "|  | ";
                st[i] += counts[1] >= i + 1 ? string.Format("|{0}| ", pilhas[1].Item(i).id) : "|  | ";
                st[i] += counts[2] >= i + 1 ? string.Format("|{0}| ", pilhas[2].Item(i).id) : "|  | ";
                st[i] += counts[3] >= i + 1 ? string.Format("|{0}|\n", pilhas[3].Item(i).id) : "|  |\n";
            }

            s += st[2] + st[1] + st[0];

            Console.Write(s + _end);
        }
    }
}
