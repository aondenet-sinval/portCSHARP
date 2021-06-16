using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaApp
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, string autor, float preco)
        {
            this.nome = nome;
            this.autor = autor;
            this.preco = preco;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no Curso: {nome}");
            Console.WriteLine($"Digite a quantidade de vagas disponíveis...");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque + entrada;
            vagas += entrada;
            Console.WriteLine("Quantidade de vagas  registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vagas no curso: {nome}");
            Console.WriteLine($"Digite a quantidade de vagas a consumir");
            int entrada = int.Parse(Console.ReadLine());
            //estoque = estoque + entrada;
            vagas -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Cursos:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas: {vagas}");
            Console.WriteLine("============================");
        }
    }
}
