using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersecaoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declara variáveis e lê entradas
            string linhaUm, linhaDois;
            Console.WriteLine("Insira as matrículas de Programação separadas por vírgula");
            linhaUm = Console.ReadLine();
            Console.WriteLine("Insira as matrículas de Modelagem separadas por vírgula");
            linhaDois = Console.ReadLine();
            int[] prog = new int[linhaUm.Split(',').Length];
            int[] mod = new int[linhaDois.Split(',').Length];

            List<int> result = new List<int>();

            //Converte entradas para Int conforme solicitado.

            for(int i = 0; i < prog.Length; i++)
            {
                prog[i] = int.Parse(linhaUm.Split(',')[i]);
            }
            for (int i = 0; i < mod.Length; i++)
            {
                mod[i] = int.Parse(linhaDois.Split(',')[i]);
            }

            //Compara strings e insere na lista os compatíveis, já que o resultado pode ser de tamanho diferente

            for(int i = 0;i < prog.Length; i++)
            {
                for(int j = 0; j < mod.Length; j++)
                {
                    if (prog[i] == mod[j])
                    {
                        result.Add(prog[i]);
                        break;
                    }
                }
            }

            result.ForEach(r => Console.WriteLine(r));
            Console.ReadLine();
        }
    }
}
