using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Cor { get; set; }
        public bool CondicaoNovo { get; set; }
        public string Marca { get; set; }

        public Produto(string nome, double preco, int quantidade, string cor, bool condicaoNovo, string marca)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Cor = cor;
            CondicaoNovo = true;
            Marca = marca;
        }
    }
}
