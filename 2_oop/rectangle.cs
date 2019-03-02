using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2_oop
{
    public class Rectangle
    {
        private string brushColor;
        private string stColor;
        private double length;
        private double width;

        Colors colors = new Colors();
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="l">Длинна</param>
        /// <param name="w">Ширина</param>
        /// <param name="bc">Цвет заливки</param>
        /// <param name="sc">Цвет обводки</param>
        public Rectangle(double l,double w,string  bc,string sc)
        {
            this.length = l;
            this.width = w;
            this.stColor = colors.Color(sc);
            this.brushColor = colors.Color(bc);
        }
        public double Sqrt()
        { return length * width; }
        public double Per()
        { return (length + width)*2; }
        public void FigInfo(Rectangle rectangle)
        {
            string a = "Rectangle: " + " \n Brush " + rectangle.brushColor + " \n Strick " + rectangle.stColor + " \n Length: " + rectangle.length + " \n Perimeter: " + rectangle.Per()  + " \n Square: " + rectangle.Sqrt();
            Console.WriteLine(a);
        }
        
    }
}
