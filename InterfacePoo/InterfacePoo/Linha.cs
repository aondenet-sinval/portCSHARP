using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePoo
{
    class Linha : Drawble
    {
        public override float Area()
        {
            return 0;
        }

        public override void Draw()
        {
            Console.WriteLine("... abstrata");
        }
    }
    /*
    class Linha : IDrawble
    {
        public float Area()
        {
            return 20;
        }

        public void Draw()
        {
            Console.WriteLine("Linha....");
        }

    }
    */
}
