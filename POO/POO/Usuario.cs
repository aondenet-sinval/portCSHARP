using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Usuario
    {
        public string nome;
        public string email;
        public string senha;

        public Usuario(string nome, string email, string senha)//construtor em herança
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public void Logar()
        {
            Console.WriteLine("Usuários logados:");
        }
        //usando polimorfismo de sobrecarga
        public void Logar(string log1)
        {
            Console.WriteLine("log1 polimorfismode sobrecarga");
        }
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
        }
        /*possibilitando sobrescrita no método
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
        }*/
    }
    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Verspertino";

        public void Estudar()
        {
            Console.WriteLine("Matéria de estudo: Português");
        }

        public Aluno(string nome, string email, string senha) : base(nome,email,senha)//construtor em herança
        {
            //this.turno = turno;
        }
        public override void Exibir()
        {
            Console.WriteLine("Dados do aluno: ");
            base.Exibir();
            Console.WriteLine("alterando método sobrescrito da classe pai");
        }
    }
    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();

        public Zelador(string nome, string email,string senha) : base(nome, email, senha)//construtor em herança
        {

        }
    }
}
