using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LojaInstrumentos.Entities;

namespace LojaInstrumentos
{
    class Program
    {

        private static void AdicionarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
        private static void ListarProdutos()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CONTROLE DE ESTOQUE - LOJA DE INSTRUMENTOS");

            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");

            string item = Console.ReadLine();

            if (item == "1")
            {
                Console.WriteLine("Informe o nome do Instrumento:");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o preço:");
                double preco = double.Parse(Console.ReadLine());



                Console.WriteLine("Informe a cor do instrumento:");
                string cor = Console.ReadLine();

                Console.WriteLine("Informe a condição do instrumento(Novo/Usado):");
                bool condicaoNovo = true;
                string condicao = Console.ReadLine();
                if (condicao == "Novo")
                {
                    condicaoNovo = true;
                }
                else if (condicao == "Usado")
                {
                    condicaoNovo = false;
                }


                Console.WriteLine("Informe a marca do instrumento:");
                string marca = Console.ReadLine();


                int quantidade = 0;


                Produto produto = new Produto(nome, preco, quantidade, cor, condicaoNovo, marca);
                AdicionarProduto(produto);
                Console.WriteLine("Novo instrumento adicionado no estoque!");

            }
            else if (item == "2")
            {
                ListarProdutos();
            }
            else if (item == "3")
            {
                Console.WriteLine("Informe a posição do instrumento a ser removido");


            }
            else if(item == "4")
            {

            }
            else if(item == "5")
            {

            }


        }


    }
}
