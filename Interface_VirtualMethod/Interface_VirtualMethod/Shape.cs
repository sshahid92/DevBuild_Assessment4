using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_VirtualMethod
{
    //A. we were told to not use an interface and use a class instead that printed the below method
    class Shape
    {
        public Shape()
        {
        }

        public virtual void Draw()
        {
            Console.WriteLine("Hi, I am a shape.");
        }
    }
}
