using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_VirtualMethod
{
    //B. square class that inherits from Shape
    class Square : Shape
    {
        //G.
        public float Side { get; set; }

        //E.
        public Square()
        {
            Side = 0;
        }

        //F.
        public Square(float side)
        {
            Side = side;
        }

        //C. Override method
        public override void Draw()
        {
            Console.WriteLine("Hi, I'm a square!");
        }

        //D.
         public float GetArea()
        {
            return Side * Side;
        }
    }
}
