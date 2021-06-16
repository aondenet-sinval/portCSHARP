using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com listas. Algo melhor que arrays
            List<string> clientes = new List<string>();
            clientes.Add("Sinval");
            clientes.Add("Sinval");
            clientes.Add("Sinval");
            clientes.Add("Sinval");
            clientes.Add("Adriana");
            clientes.Add("Claudinha");
            clientes.Add("Maria Isabel");
            clientes.Add("Joécia Santana");
            clientes.Add("Enilfa Valadares");
            Console.WriteLine("Posição antes de aplicar RemoveAt: "+clientes[1]);
            //Exibindo a quantidade de itens na lista com 'count'
            Console.WriteLine("Contagem antes de aplicar RemoveAt a lista possui: "+clientes.Count+" itens.");
            //remoção pelo índice 
            clientes.RemoveAt(1);
            Console.WriteLine("Posição depois de aplicar RemoveAt: "+clientes[1]);
            Console.WriteLine("Contagem depois de aplicar RemoveAt a lista possui: "+clientes.Count+" itens.");
            //Usando a remoção por meio do predicado:
            //int removidos = clientes.RemoveAll(cliente => cliente == "Sinval");
            //Console.WriteLine($"Foram removidos {removidos}.");
            //Busca de elementos com a biblioteca Linq (Find e FindAll) usando predicado ainda:
            //string busca = clientes.Find(cliente => cliente == "Sinval");
            //Console.WriteLine($"Busca pela variável{busca}");
            string valor = clientes.Find(cliente => cliente.Length > 5);
            if (valor == null)
            {
                Console.WriteLine("Semitens");               
            }
            /*foreach (var item in busca)
            {
                Console.WriteLine($"com mais de 8 caraceres: {item}");                
            }
            */
            
            List<string> listafiltre = clientes.FindAll(cliente => cliente.Length == 6);
            foreach (var filtro in listafiltre)
            {
                Console.WriteLine("Filtrada com a condição da variável listafiltre: "+filtro);                
            }
            /*
            //Trabalhando com listas int. Algo melhor que arrays
            List<int> impares = new List<int>();
            impares.Add(0101);
            impares.Add(0103);
            impares.Add(0105);
            impares.Add(0107);
            Console.WriteLine("Posição 2 antes de aplicar RemoveAt: "+impares[2]);
            //Exibindo a quantidade de itens na lista com 'count'
            Console.WriteLine("Contagem antes de aplicar RemoveAt a lista possui: "+impares.Count+" itens.");
            //remoção pelo índice 
            impares.RemoveAt(1);
            Console.WriteLine("Posição 2 depois de aplicar RemoveAt: "+impares[2]);
            //Exibindo a quantidade de itens na lista com 'count'
            Console.WriteLine("Contagem depois de aplicar RemoveAt a lista possui: "+impares.Count+" itens.");
            //Usando a remoção por meio do predicado:
            //clientes.RemoveAll(cliente => cliente == "Joécia");
            //Busca de elementos:
            int retornarImpar = impares.Find(impar => impar > 0101);
            //Console.WriteLine("Retorno impar: " + retornarImpar);
            foreach (var item in retornarImpar)
                {
                Console.WriteLine(item);
                }*/
        }
    }
}
