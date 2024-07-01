using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA5
{ 
class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box box1, Box box2)
        {
            int newLength = box1.Length + box2.Length;
            int newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Breadth: {Breadth}");
            Console.Read();
        }
    }

    class Test
    {
        static void Main()
        {
            Box box1 = new Box(2, 3);
            Box box2 = new Box(10, 6);

            Box box3 = Box.Add(box1, box2);

            Console.WriteLine("Box 1 Dimensions:");
            box1.Display();
            Console.WriteLine();

            Console.WriteLine("Box 2 Dimensions:");
            box2.Display();
            Console.WriteLine();

            Console.WriteLine("Box 3 Dimensions ( Addition of Box1 and Box2):");
            box3.Display();
        }
    }

}