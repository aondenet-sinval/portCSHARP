
sing System;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;//Incluir essa biblioteca depois
using System.Net;

namespace HTTP
{
    class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed; 

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine("Tarefas: ");
            Console.WriteLine($"User ID: {userId}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Título: {title}");
            Console.WriteLine($"Status: {completed}");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
        }
    }
}