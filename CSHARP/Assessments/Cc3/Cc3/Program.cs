using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cc3
{
    using System;

    public class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public Box(int len, int brea)
        {
            Length = len;
            Breadth = brea;
        }
        public static Box total(Box box1, Box box2)
        {
            int box3Leng = box1.Length + box2.Length;
            int box3Bread = box1.Breadth + box2.Breadth;
            return new Box(box3Leng, box3Bread);
        }
        public void Display()
        {
            Console.WriteLine($"Box Values- Len: {Length}, Brea: {Breadth}");
            Console.Read();
        }
    }
    public class Test
    {
        public static void Main()
        {

            Console.WriteLine("Enter box1 values:");
            Console.Write("Enter breadth of Box 1: ");
            int brea1 = int.Parse(Console.ReadLine());
            Console.Write("Enter length of Box 1: ");
            int len1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter box2 values:");
            Console.Write("Enter breadth of Box 2: ");
            int brea2 = int.Parse(Console.ReadLine());
            Console.Write("Enter length of Box 2: ");
            int len2 = int.Parse(Console.ReadLine());

            Box box1 = new Box(len1, brea1);
            Box box2 = new Box(len2, brea2);
            Box box3 = Box.total(box1, box2);
            Console.WriteLine("Box values:");
            box3.Display();

            Console.ReadLine();
        }
    }
}


