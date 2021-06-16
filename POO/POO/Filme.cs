using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;
        private List<string> atores = new List<string>();

        //Definição estática
        public string serie = "Pedrinho e Sofia";

        public Filme(string nome, string desc, int ano, string studio)//Definindo Filme como construtor
        {
            this.nome = nome;
            this.desc = desc;
            this.ano = ano;
            this.studio = studio;

            Console.WriteLine("Detalhando no C#");
        }


        public void Executar()
        {
            atores.Add("sd");
            //Console.WriteLine(filme.nome);
            Console.WriteLine("Filme sendo executado: " + serie + atores);

        }
        
        public void Pausar()
        {
            Console.WriteLine("Você definiu o filme: "+serie);
            Console.WriteLine("Filme em pausa: " + nome);
        }

        public void AddAtor(string nome)
        {
            if(nome != null)
            {
                if(nome.Length > 7)
                {
                    atores.Add(nome);
                }
            }    
        }
        public void ExibirAtor()
        {
            foreach(string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }
        
    }
}
