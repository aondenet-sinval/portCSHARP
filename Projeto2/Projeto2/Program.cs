using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

//18:23
namespace Projeto2
{
    class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }
        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de Clientes - Bem vindo!");
                Console.WriteLine("1 - Listagem\n2 - Adicionar\n3 - Remover\n4 - Sair");

                int inOpt = int.Parse(Console.ReadLine());
                Menu Opcao = (Menu)inOpt;

                switch (Opcao)
                {
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        Console.WriteLine("Cliente Cadastrado com sucesso. Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }


            }
            Console.WriteLine("Aperte Enter para sair.");
            Console.ReadLine();
        }
        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de cliente:");
            Console.WriteLine("Qual o nome do cliente?");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Qual o email do cliente?");
            cliente.email = Console.ReadLine();
            Console.WriteLine("Qual o CPF do cliente?");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();
        }
        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                Console.WriteLine("Lista de clientes:");
                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}.");
                    Console.WriteLine($"Email: {cliente.email}.");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("======================");
                    i++;
                    
                }
            }
            else
            {
                Console.WriteLine("Não há clientes cadastrados.");
            }

        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do cliente a ser removido.");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("ID inválido. Tente novamente.");
            }
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("clients.pdf",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close();

        }
        static void Carregar()
        {
            FileStream stream = new FileStream("clients.pdf", FileMode.OpenOrCreate);
            try
            {        
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);
                if (clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            
            }
            catch (Exception)
            {
                clientes = new List<Cliente>();
            }
            stream.Close();

        }
    }
}
