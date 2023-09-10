using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Contato
    {
        private readonly int _id;

        public Contato()
        {
            Random random = new Random();
            _id = random.Next();
        }
        public Contato(string nome, string email, long telefone) : this()
        {
            this.Email = email;
            this.Telefone = telefone;
            this.Nome = nome;
        }

        public int Id { get;  }
        public string Nome { get; set; }
        public string Email { get; set;}
        public long Telefone { get; set; }  
       
    }
}
