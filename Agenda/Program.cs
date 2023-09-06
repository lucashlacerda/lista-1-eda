using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao1;
            string nome, email;
            int telefone;

            Agenda agenda = new Agenda();
            Console.WriteLine("Insira sua necessidade:\n 1. Adicionar contato \n2. Remover contato\n3. Buscar contato por nome" +
                "4. Buscar contato por email\n5. Buscar contato por telefone");
            opcao1 = Console.ReadKey();

            switch(opcao1)
            {
                case 3:
                    Console.WriteLine("Insira o nome a ser buscado:");
                    nome = Console.ReadLine();
                    agenda.BuscarContatoPorNome(nome);
                    break;
                case 4:
                    Console.WriteLine("Insira o email a ser buscado:");
                    email = Console.ReadLine();
                    agenda.BuscarContatoPorEmail(email);
                    break;
                case 5:
                    Console.WriteLine("Insira o telefone a ser buscado:");
                    telefone = int.Parse(Console.ReadLine());
                    agenda.BuscarContatoPorTelefone(telefone);
                    break;

            }
        }
    }
}
