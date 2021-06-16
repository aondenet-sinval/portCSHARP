using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;
//using Newtonsoft.Json;//Incluir essa biblioteca depois
using System.Net;

namespace HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Reqlist();

            ReqUnica();

            Console.ReadLine();         
        }
        static void Reqlist()
        {
                var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
                requisicao.Method = "GET";
                using (var resposta = requisicao.GetResponse())
                {
                    var stream = resposta.GetResponseStream();
                    StreamReader leitor = new StreamReader();
                    object dados = leitor.ReadToEnd();
                    //Console.WriteLine(dados.ToString());
                    List<Tarefa> tarefas = JsonConverter.DeserilizeObject<List<Tarefa>>(dados.ToString());
                    foreach (Tarefa tarefa in tarefas)
                    {
                        tarefa.Exibir();
                    }
                    stream.Close();
                    resposta.Close();
                }
            } 
            static void ReqUnica()
            {
                var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
                requisicao.Method = "GET";
                using (var resposta = requisicao.GetResponse())
                {
                    var stream = resposta.GetResponseStream();
                    StreamReader leitor = new StreamReader();
                    object dados = leitor.ReadToEnd();
                    //Console.WriteLine(dados.ToString());
                    Tarefa tarefas = JsonConverter.DeserilizeObject<List<Tarefa>>(dados.ToString());
                    foreach (Tarefa tarefa in tarefas)
                    {
                        tarefa.Exibir();
                    }
                    stream.Close();
                    resposta.Close();
                }
            }  
    }
}
