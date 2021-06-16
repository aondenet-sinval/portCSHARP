using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePoo
{
    class Rect : Drawble
    {
        public override float Area()
        {
            return 20.4f;
        }

        public override void Draw()
        {
            Console.WriteLine("Retangulos...");
        }
    }
    /*class Rect : IDrawble
    {
        public float Area()
        {
            return 20.4f;            
        }

        public void Draw()
        {
            Console.WriteLine("Retangulos...");
        }
    }
    */
}
