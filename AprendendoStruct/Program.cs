using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStruct
{
    class Program
    {
        struct Carne
        {
            public string nome;
            public float peso;
            public float preco;

            public Carne(string nome, float peso, float preco)
            {
                this.nome = nome;
                this.peso = peso;
                this.preco = preco;

            }
            public void ExibirValores()
            {
                float desconto = preco * 0.05f;
                float promo = preco - desconto;
                desconto = (float)Math.Round(desconto,2);
                promo = (float)Math.Round(promo,2);
                Console.WriteLine($"Produto: {nome}");
                Console.WriteLine($"Qtde: {peso}Kg");
                Console.WriteLine($"Valor sem desconto: {preco}");
                Console.WriteLine($"Valor com decconto: {promo}");

                Caramba();
            }
            public void Caramba()
            {
                Console.WriteLine("Eita caramba");
            }
        }

        static void Main(string[] args)
        {
            Carne musculo = new Carne("Musculo bovino traseiro", 1f, 20f);
            Carne carre = new Carne("Carre suíno", 1f, 17.45f);


            carre.ExibirValores();
            musculo.ExibirValores();

            
        }
    }
}
