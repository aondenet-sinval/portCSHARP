using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;//módulo serializador

namespace ManipularArquivos
{

    class Program
    {
    [System.Serializable]
    //Instrução System.Seriazable é necessária para adicionar os dados dos 
    //tipos produtos em arquivos binários
    struct Produtos
    {
        public string nome;
        public float preco;
        public int qtde;
    }
        static void Main(string[] args)
        { //pausa: 59:30
            //Aula escrevendo em arquivos binários
            //Abrir/criar o arquivo aqui está abrindo ou criando
            FileStream stream = new FileStream("arquivobin.sinva",FileMode.OpenOrCreate);
            //Para escrever é precis de uma serializador que converte para cadeia de bytes
            BinaryFormatter encodef = new BinaryFormatter();

            //usando listas
            List<string> langs = new List<string>();
            langs.Add("Python");
            langs.Add("CSS3");
            langs.Add("W3CSS");
            langs.Add("C#");
            langs.Add("C++");

            //trabalhando com os tipos
            Produtos frutas = new Produtos();
            frutas.nome = "jaca";
            frutas.preco = 29f;
            frutas.qtde = 220;

            //Gravando os tipos criados
            //encodef.Serialize(stream,frutas);
            //encodef.Serialize(stream,langs);
        

            /*//Instrução para escrever individualmente
            encodef.Serialize(stream,130);
            encodef.Serialize(stream,"Sinval Gomes dos Santos");
            encodef.Serialize(stream,1.30);*/

            //Abaixo vamos fazer a leitura do arquivo binário
            List<string> listalendo = (List<string>)encodef.Deserialize(stream);
            Produtos listado = (Produtos)encodef.Deserialize(stream);
            Console.WriteLine(listalendo[0]);
            Console.WriteLine(listado.nome);
            
            //Finalizando a escrita e fechando o fluxo
            stream.Close();
            Console.ReadLine();

            //--------------------------------------------
            /*
            //Leitura do arquivo de texto com StreamReader:
            StreamReader leitura = new StreamReader("arquivoA.txt");
            //string lidos = leitura.ReadToEnd();//ReadToEnd lê tudo
            //string lidos = leitura.ReadLine();//ReadLine lê uma linha a cada execução
            //Console.WriteLine(lidos);
            List<string> linhas = new List<string>();//Acessando conteudo no arquivo com listagem
            string letudo = "";

            //string lista = linhas;

            while (letudo != null)
            {
                letudo = leitura.ReadLine();
                if (letudo != null)
                {
                    linhas.Add(letudo);
                    //A instrução abaixo imprime o caracter na coluna 6 da lista
                    //Cada coluna na lista inicia com a posição 0
                    //Console.WriteLine(letudo[5]);                                       
                }
                                
            }
            leitura.Close();//fechando o fluxo com o arquivo
            //A instrução abaixo imprime o caracter na linha 1 da lista
            //Cada linha na lista inicia com a posição 0
            Console.WriteLine(linhas[8]); 
            */
            //Imprimindo todas as linhas da lista
            /*
            Console.WriteLine("=================");
            foreach (string item in linhas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================");
            //Console.WriteLine(lidos);
            */
            /*//Criação de arquivos de texto e atualização com StreamWriter:
            //Abrir fluxo para criar e escrever no arquivo. Apaga dados anteriores caso o arquivo já tenha sido criado
            //StreamWriter escritor = new StreamWriter("arquivoA.txt");
            //Abrir fluxo para escrever no arquivo sem apagar os dados inseridos
            StreamWriter escritor = File.AppendText("arquivoA.txt");
            escritor.WriteLine("2 - Sinval Gomes dos Santos");
            escritor.WriteLine("Curso de C#");
            escritor.WriteLine("Nível Avançado");
            escritor.Close(); 
            //string lendo = Console.ReadLine(escritor);
            //Console.WriteLine(lendo);
            */
        }
    }
}
