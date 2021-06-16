using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaApp
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, string autor, float preco)
        {
            this.nome = nome;
            this.autor = autor;
            this.preco = preco;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("O item Ebooks não requer entrada em estoqque");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no ebook: {nome}");
            Console.WriteLine($"Digite a quantidade de Ebooks vendidos");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque + entrada;
            vendas += entrada;
            Console.WriteLine("Venda/Saída registrada");
            Console.ReadLine(); ;
        }

        public void Exibir()
        {
            Console.WriteLine("Ebooks:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendidos: {vendas}");
            Console.WriteLine("============================");
        }
    }
}
