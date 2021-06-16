using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exemplo de uso didático programa de desenho com interface
//com funções de desenho Linha, Retangulo e quadrado
//Criei classes para representar
//Usando interface tem-se a garantia de que as classes terão os mesmos métodos
namespace InterfacePoo
{
    abstract class Drawble
    {
        //Uma diferença de classe abstrata para interface
        //A classe abastrata permite o uso de atributos isso não é possível em interface
        //A classe abstrata cria uma relaçção de herança com a classe filha
        //Diferente da interface que não cria relação de herança
        public string cor;//atributo cor
        /*public void Draw()
        {
            Console.WriteLine("Abstrata ");
        }*///Ao usar classes abstratas o método é obrigado a retornar alguma coisa
        //quando definido o tipo como abaixo. Coloquei o retorno 3.4f
        //usando abstract na frente do método não é obrigatório retornar nada
        public abstract void Draw();//Exemplo sem retorno
        public abstract float Area();//Exemplo sem retorno
        //O exemplo acima com abastract é similar ao uso da interface
        /*float Area()
        {
            return 3.4f;
        }*/
    }
    interface IDrawble
    {
        void Draw();//definindo método que será publico. Não é necessário usar a palavra public
        float Area();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Drawble shape = new Rect();
            shape.Draw();
            /*IDrawble shape = new Rect();
            shape.Area();
            */
            Console.ReadLine();
        }
    }
}
