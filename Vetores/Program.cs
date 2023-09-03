using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];
            string input;

            Console.WriteLine("Insira X, Y e Z separados por vírgula");

            input = Console.ReadLine();

            valores[0] = int.Parse(input.Split(',')[0]);
            valores[1] = int.Parse(input.Split(',')[1]);
            valores[2] = int.Parse(input.Split(',')[2]);

            imprimeMaiorEMenor(valores);

            void imprimeMaiorEMenor(int[] val)
            {
                int[] ordenado = ordenar(val);

                Console.WriteLine("Maior {0} e Menor {1}", ordenado[0], ordenado[ordenado.Length - 1]);

            }

            int[] ordenar(int[] n) {
                int aux;
                
                for (int i = 0; i < n.Length; i++)
                {
                    for (int j = 0; j < n.Length -1; j++)
                    {
                        if (n[i] > n[j])
                        {
                            aux = n[i];
                            n[i] = n[j];
                            n[j] = aux;
                        }
                    }
                }
                    return n;
            }

            bool verificaIntervalo(int[] val)
            {
                if(val[1] > val[2])
                {
                    if(val[0] < val[1] && val[0] > val[2])
                    {
                        return true;
                    }
                }
                else if (val[1] < val[2])
                {
                    if(val[0] > val[1] && val[0] < val[2])
                    {
                        return true;
                    }
                }
                return false;
            }

            string verificaDivisibilidade(int[] args)
            {
                bool porY = false, porZ = false;
                if (args[0] % args[1] == 0)
                {
                    porY = true;
                }
                if(args[0] % args[2] == 0)
                {
                    porZ = true;
                }
                
                if(porY && porZ)
                {
                    return "X é divisível por Y e Z";
                }else if(porY && porZ == false)
                {
                    return "X é divisível por Y mas não por Z";
                }else if(porY == false && porZ == true)
                {
                    return "X é divisível por Z mas não por Y";
                }

                return "X não é divisível por Y ou Z";

            }

            Console.ReadLine();
        }
    }
}
