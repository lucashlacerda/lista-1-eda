using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniaoVetores
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
            int[] vetX = new int[linhaUm.Split(',').Length];
            int[] vetY = new int[linhaDois.Split(',').Length];
            bool aux = false;
            List<int> result = new List<int>();

            //Converte entradas para Int conforme solicitado.

            for (int i = 0; i < vetX.Length; i++)
            {
                vetX[i] = int.Parse(linhaUm.Split(',')[i]);
            }
            for (int i = 0; i < vetY.Length; i++)
            {
                vetY[i] = int.Parse(linhaDois.Split(',')[i]);
            }

            //Insere todos os itens do Vetor X na lista result

            foreach (int i in vetX) {result.Add(i);}

            for (int i = 0;i < vetY.Length; i++)
            {
                aux = false;
                for (int j = 0; j < vetX.Length; j++)
                {
                    if (vetY[i] == vetX[j])
                    {
                        aux = true;
                    }
                }
                if (!aux)
                {
                    result.Add(vetY[i]);
                }
            }


            Console.WriteLine(".......................");
            result.ForEach(r => Console.WriteLine(r));
            Console.ReadLine();
        }
    }
}
