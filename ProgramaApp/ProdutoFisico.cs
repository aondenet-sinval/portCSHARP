using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaApp
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico()
        {
        }

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque: {nome}");
            Console.WriteLine($"Digite a quantidade a entrar em estoque");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque + entrada;
            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saida no estoque: {nome}");
            Console.WriteLine($"Digite a quantidade baixada do estoque:");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque - entrada;
            estoque -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Produto Físico:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade em estoque: {estoque}");
            Console.WriteLine("============================");
        }
    }
}
