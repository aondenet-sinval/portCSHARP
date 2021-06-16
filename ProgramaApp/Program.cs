using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaApp
{
    class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();

        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }

        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.Write("Sistema de Estoque");
                Console.WriteLine("\n1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saída\n6 - Sair do Sistema");
                string optStr = Console.ReadLine();
                int opInt = int.Parse(optStr);
                Menu escolha = (Menu)opInt;

                if (opInt > 0 && opInt < 7)
                {
                    switch (escolha)
                    {
                        case Menu.Listar:
                            //Console.WriteLine("Listando");
                            Listagem();
                            break;
                        case Menu.Adicionar:
                            //Console.WriteLine("Adicionando");
                            Cadastro();
                            break;
                        case Menu.Remover:
                            //Console.WriteLine("Removendo");
                            Remover();
                            break;
                        case Menu.Entrada:
                            //Console.WriteLine("Entrada");
                            Entrada();
                            break;
                        case Menu.Saida:
                            //Console.WriteLine("Saída");
                            Saida();
                            break;

                        case Menu.Sair:
                            Console.WriteLine("Você escolheu sair? Tecle Enter para confirmar");
                            escolheuSair = true;
                            break;
                    }
                }else
                {
                    Console.WriteLine("Escolha uma das opções do Menu.");
                }
            }
            Console.Clear();

        }
        static void Listagem()
        {
            Console.WriteLine("Listagem de Produtos.");
            int i = 0;
            foreach(IEstoque produto in produtos)
            {
                Console.WriteLine("ID: " + i);
                produto.Exibir();
                i++;
            }
            Console.ReadLine();
        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do item que será removido:");
            int id = int.Parse(Console.ReadLine());
            if(id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Salvar();
            }
        }
        static void Entrada()
        {
            Listagem();
            Console.WriteLine("Digite o ID do item que você quer dar entrada:");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarEntrada();
                Salvar();
            }
        }
        static void Saida()
        {
            Listagem();
            Console.WriteLine("Digite o ID do item que você quer dar saida:");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarSaida();
                Salvar();
            }
        }
        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produto:");
            Console.WriteLine("1 - Produto físico\n2 - Ebook\n3 - Curso");
            string optstr = Console.ReadLine();
            int escolhaInt = int.Parse(optstr); 
            switch(escolhaInt)
            {
                case 1:
                    CadastroPFisico();
                    break;
                case 2:
                    CadastroEbook();
                    break;
                case 3:
                    CadastroCurso();
                    break;
            }
        }
        static void CadastroPFisico()
        {
            Console.WriteLine("Cadastro de Produto físico:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete:");
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
            Salvar();
        }

        static void CadastroEbook()
        {
            Console.WriteLine("Cadastro de Ebook:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Ebook eb = new Ebook(nome, autor, preco);
            produtos.Add(eb);
            Salvar();
        }
        static void CadastroCurso()
        {
            Console.WriteLine("Cadastro de Curso:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Curso cc = new Curso(nome, autor, preco);
            produtos.Add(cc);
            Salvar();
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, produtos);
            stream.Close();
         }
        static void Carregar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();
            try
            {
                produtos = (List<IEstoque>)encoder.Deserialize(stream);
                if (produtos == null)
                {
                    produtos = new List<IEstoque>();
                }
            }
            catch (Exception e)
            {

            }
            stream.Close();
        }

    }
}
