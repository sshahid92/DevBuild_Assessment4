using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Console.WriteLine(square.GetArea());
            Console.ReadLine();
            //H.
            /*I applied SOLID by having a single class being responsible for all thing related to the square.
             *Square inherits from Shape which allowed me to create and abstract method that any shape i create 
             * going forward can use and alter. this adds an element of polymorphism that satisfies liscovs principle. 
             * Also by doing this the base class does not depend on the subclass
             By applying SOLID i was able to add an area method to square that other child classes of shape wont 
             have to worry about*/
        }
    }
}
