using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenealogica
{
    internal class ArvoreGenealogica
    {
        private List<Pessoa> _pessoas;

        public ArvoreGenealogica()
        {
            _pessoas = new List<Pessoa>();
        }

        public List<Pessoa> PesquisarFilhos(Pessoa pessoa)
        {
            List<Pessoa> filhos = new List<Pessoa>();
            
            _pessoas.ForEach(p => { if(p.Pai == pessoa) {  filhos.Add(p); } });

            return filhos;

        }
        public List<Pessoa> PesquisarIrmaos(Pessoa pessoa)
        {
            List<Pessoa> irmaos = new List<Pessoa>();

            _pessoas.ForEach(p => { if (p.Pai == pessoa.Pai || p.Mae == pessoa.Mae) { irmaos.Add(p); } });

            return irmaos;

        }
        public string AdicionarPessoa(Pessoa p)
        {
            _pessoas.Add(p);
            return "Pessoa adicionada com sucesso";
        }
        public string RemoverPessoa(Pessoa p)
        {
            if (_pessoas.Remove(p))
            {
                return "Pessoa removida com sucesso";
            }
            return "Não foi possível identificar essa pessoa";
        }

        public Pessoa BuscarPessoa(string nome)
        {
            Pessoa pessoaBuscada = new Pessoa();
            _pessoas.ForEach(p => {if(p.Nome == nome) { pessoaBuscada = p;} 
            });
            return pessoaBuscada;
        }
    }
}
