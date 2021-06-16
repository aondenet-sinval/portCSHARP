using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{//0:23:28, 1:03:50 
    class Program
    {
        static void Main(string[] args)
        {
            //trabalhando com conceito de herança
            Usuario snv = new Aluno("Sinval Gomes add","sinval@email.add","senha.add");
            Usuario sv = new Zelador("Sinval Gomes add zelador", "sinval@email.add", "senha.add");
            //Console.WriteLine(((Zelador)sv).tarefas);
            snv.Exibir();
            snv.Logar();//chamando método sem o polimorfismo de sobrecarga
            //snv.Logar("log1");//chamando método usando polimorfismo de sobrecarga
            //Aluno sinval = new Aluno("Sinval Gomes","sinaval@dd","1234");//com construtor
            /*//Definindo aluno sem construtor
            sinval.nome = "Sinval Gomes";
            sinval.email = "sinval@add";
            sinval.senha = "1234";
            sinval.turno = "";
            */
           // sinval.Logar();
            //sinval.Exibir();

            //Zelador zela = new Zelador("seu josé","jj@gmail","234");//Com construtor
           /*//definindo zelador sem construtor
            zela.senha = "1234";
            zela.email = "";
            zela.nome = "Seu João";
            zela.tarefas.Add("Limpar o chão");
            */
            //zela.Exibir();

            //Console.WriteLine(sinval.nome);
            /*
            //Trabalhando com construtor
            //Passando os parametros para o construtor Filme
            Filme filme = new Filme("O filho Pródigo","Baseado na Ilustração de Jesus",2021,"JW.org");
            Filme jwxl = new Filme("Profeta Jonas","",22,"");
            jwxl.AddAtor("Ator: Jonas ");
            jwxl.AddAtor(null);
            jwxl.AddAtor("Davi");
            jwxl.AddAtor("João o Batizador");
            jwxl.ExibirAtor();
            Console.WriteLine(filme.nome+" "+filme.ano);
            Console.WriteLine(jwxl.nome+" "+jwxl.ano);
            */
            //Filme.nome = "O flho pródigo";
            //Filme.Executar();
            /*//ttrabalhando aqui sem construtor Filme
            Filme filme = new Filme();
            filme.nome = "Filme desconhecido";

            Filme filme2 = new Filme();
            filme2.nome = "O nome divino durará para sempre!!!";
            filme.Executar();
            Console.WriteLine("Escreva o filme");
            Filme.serie = Console.ReadLine();//"O amor nunca acaba";//redefinindo a variável estática
            filme2.Pausar();*/
            Console.ReadLine();
        }
    }
}
