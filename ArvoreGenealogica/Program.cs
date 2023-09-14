using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenealogica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = 0;
            string nomePessoa, nomePai, nomeMae;

            bool execucao = true;
            while(execucao)
            {

                Console.WriteLine("Insira sua necessidade:\n1. Adicionar pessoa na árvore\n2. Remover pessoa da árvore\n3. Buscar filhos\n" +
                    "4. Buscar irmãos\n5. Buscar pessoa\n6. Finalizar");
                opcaoUsuario = int.Parse(Console.ReadLine());

                if (opcaoUsuario == 1)
                {
                    Console.WriteLine("Para adicionar uma pessoa, preciso de alguns dados.\nInsira o nome da nova pessoa:");
                    nomePessoa = Console.ReadLine();
                    Console.WriteLine("Insira o nome do pai:");
                    nomePai = Console.ReadLine();
                    Console.WriteLine("Insira o nome da mãe:");
                    nomeMae = Console.ReadLine();

                }
                else if (opcaoUsuario == 2)
                {

                }
                else if (opcaoUsuario == 3)
                {

                }
                else if (opcaoUsuario == 4)
                {
                }
                else if (opcaoUsuario == 5)
                {

                }
                else if (opcaoUsuario == 6)
                {
                }
                else
                {
                }
                Console.ReadLine();

            }
        }
    }
}
