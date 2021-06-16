using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePoo
{
    class Quad : IDrawble
    {
        public float Area()
        {
            return 2;
        }

        public void Draw()
        {
            Console.WriteLine("Quadrados .....");
        }
    }
}
