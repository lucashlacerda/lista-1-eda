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
            bool rodando = true;
            while(rodando)
            {
                int opcaoUsuario;
                string nome, email;
                int id;
                long telefone;
                                
                Contato contatoBuscado, novoContato;

                Agenda agenda = new Agenda();
                Console.WriteLine("Insira sua necessidade:\n1. Adicionar contato\n2. Remover contato\n3. Buscar contato por nome\n" +
                    "4. Buscar contato por email\n5. Buscar contato por telefone\n6. Consultar tamanho da Agenda\n7. Finalizar programa");
                opcaoUsuario = int.Parse(Console.ReadLine());

                if (opcaoUsuario == 1)
                {
                    Console.WriteLine("Para adicionar um contato, preciso de alguns dados.\nInsira o nome do novo contato:");
                    nome = Console.ReadLine();
                    Console.WriteLine("Agora insira o telefone (somente os números sem espaços ou caracteres especiais):");
                    telefone = long.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o e-mail:");
                    email = Console.ReadLine();

                    novoContato = new Contato(nome, email, telefone);
                    agenda.AdicionarContato(novoContato);

                    Console.WriteLine("Contato adicionado com sucesso.");

                }
                else if (opcaoUsuario == 2)
                {
                    Console.WriteLine("Ok, para começarmos, insira o ID do contato à ser excluído:");
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(agenda.RemoverContato(id)); 
                    }catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                }
                else if (opcaoUsuario == 3)
                {
                    Console.WriteLine("Insira o nome a ser buscado:");
                    nome = Console.ReadLine();
                    contatoBuscado = agenda.BuscarContatoPorNome(nome);
                    if (contatoBuscado != null)
                    {
                        Console.WriteLine("Segue as  informações do seu contato:\nNome: {0}\nTelefone: {1}\nE-mail{2}\nID:{3}", contatoBuscado.Nome, contatoBuscado.Telefone, contatoBuscado.Email, contatoBuscado.Id);
                    }
                    else
                        Console.WriteLine("Não foi possível encontrar o contato solicitado");
                }
                else if (opcaoUsuario == 4)
                {
                    Console.WriteLine("Insira o email a ser buscado:");
                    email = Console.ReadLine();
                    contatoBuscado = agenda.BuscarContatoPorEmail(email);
                    if (contatoBuscado != null)
                    {
                        Console.WriteLine("Segue as  informações do seu contato:\nNome: {0}\nTelefone: {1}\nE-mail{2}\nID:{3}", contatoBuscado.Nome, contatoBuscado.Telefone, contatoBuscado.Email, contatoBuscado.Id);
                    }
                    else
                        Console.WriteLine("Não foi possível encontrar o contato solicitado");
                }
                else if (opcaoUsuario == 5)
                {
                    Console.WriteLine("Insira o telefone a ser buscado:");
                    telefone = long.Parse(Console.ReadLine());
                    contatoBuscado = agenda.BuscarContatoPorTelefone(telefone);
                    if (contatoBuscado != null)
                    {
                        Console.WriteLine("Segue as  informações do seu contato:\nNome: {0}\nTelefone: {1}\nE-mail{2}\nID:{3}", contatoBuscado.Nome, contatoBuscado.Telefone, contatoBuscado.Email, contatoBuscado.Id);
                    }
                    else
                        Console.WriteLine("Não foi possível encontrar o contato solicitado");
                }
                else if (opcaoUsuario == 6)
                {
                    Console.WriteLine("A quantidade de contatos atual é {0}.", agenda.QtdContatos);
                }
                else if (opcaoUsuario == 7)
                {
                    rodando = false;
                }
                else
                {
                    Console.WriteLine("A opção não é valida!");
                }
                Console.ReadLine();
            }
            
        }
    }
}
