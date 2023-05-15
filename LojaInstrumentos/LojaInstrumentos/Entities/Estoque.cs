using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos.Entities
{
    class Estoque
    {
        //Iniciando a lista produtos na memória:
        private List<Produto> produtos;

        public Estoque()
        {
            produtos = new List<Produto>();
        }


        //Métodos para adicionar e remover produtos da loja:
        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            produtos.Remove(produto);
        }

        //Método para listar os produtos existentes no estoque:
        public void ListarProdutos()
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome do produto: {produto.Nome} ({produto.Preco}) - {produto.Quantidade} no estoque.");
            }
        }

        //Método para alterar a quantidade de determinado produto no estoque:

        public void AlteraQuantidade(Produto produto, int quantidade)
        {
            produto.Quantidade += quantidade;
        }
    }
}
