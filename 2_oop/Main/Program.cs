using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_oop;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(10, 10, "Yellow", "Blue");
            Rectangle rec2 = new Rectangle(11, 30, "Yellow", "Blue");
            RectangleList<Rectangle> rectangles = new RectangleList<Rectangle>();
            BinaryTree<Rectangle> rectangles1 = new BinaryTree<Rectangle>();
            rectangles.Add(rec1);
            rectangles1.Add(rec1);
            rectangles.Add(rec2);
            rectangles1.Add(rec2);
        }
    }
}
