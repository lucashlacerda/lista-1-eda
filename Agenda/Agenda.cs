using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Agenda
    {
        List<Contato> listaDeContatos;

        public Agenda()
        {
            listaDeContatos = new List<Contato>();
        }
        public int QtdContatos { get; set; }
        public void AdicionarContato(Contato contato)
        {
            listaDeContatos.Add(contato);
            QtdContatos++;
        }

        public string RemoverContato(int id)
        {
            bool aux = false;

            listaDeContatos.ForEach(c =>
            {
                if (c.Id == id)
                {
                    aux = true;
                    listaDeContatos.Remove(c);
                }
            });

            if (aux)
            {
                return "Contato removido com sucesso";
            }
            else
                return "Não foi possível encontrar o contato";
        }

        public Contato BuscarContatoPorNome(string nome)
        {
            Contato contatoBuscado = null;
            listaDeContatos.ForEach(c =>
            {
                if(c.Nome.Equals(nome))
                {
                    contatoBuscado = c;
                }
            });
            return contatoBuscado;
        }
        public Contato BuscarContatoPorEmail(string email)
        {
            Contato contatoBuscado = null;
            listaDeContatos.ForEach(c =>
            {
                if (c.Email.Equals(email))
                {
                    contatoBuscado = c;
                }
            });
            return contatoBuscado;
        }
        public Contato BuscarContatoPorTelefone(long telefone)
        {
            Contato contatoBuscado = null;
            listaDeContatos.ForEach(c =>
            {
                if (c.Telefone == telefone)
                {
                    contatoBuscado = c;
                }
            });
            return contatoBuscado;
        }
    }
}
