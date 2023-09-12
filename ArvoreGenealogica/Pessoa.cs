using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenealogica
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa Pai { get; set; }
        public Pessoa Mae { get; set; }
        public bool EIrmao(Pessoa pessoa) {
            if(pessoa.Pai == this.Pai)
            {
                return true;
            }
            return false;
        }

    }
}
