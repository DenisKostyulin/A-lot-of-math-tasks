using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson221119
{
    class ShapeDTwo
    {
        double lenght;
        double wedth;
        public double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = Math.Abs(value);
            }
            
        }
        public double Wedth
        {
            get
            {
                return wedth;
            }
            set
            {
                wedth = Math.Abs(value);
            }
        }
        public void ShowDim()
        {
            Console.WriteLine("Значения ширины и высоты объекта");
        }
        public ShapeDTwo(double lenght, double wedth)
        {
            this.lenght = lenght;
            this.wedth = wedth;
            Console.WriteLine($"Значение высоты:{lenght}   " + $"Значение ширины:{wedth} ");
        }
    }
    class Triangle : ShapeDTwo
    {
        string style;
        public string Style
        {
            get
            {
                return style;
            }
            set
            {
                style = value;
            }
        }
public Triangle(string style, double lenght, double wedth) : base(lenght, wedth)
        {
            this.style = style;
            Console.WriteLine($"Площадь равна:  {lenght*wedth* .5}");
            Console.WriteLine($"Форма:  {style}");
        }
    }
    class Lesson221119
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("Треугольник_1", 5, 8);
            Console.WriteLine();
            Triangle t2 = new Triangle("Треугольник_2", 25, 7);
            Console.ReadLine();
        }
    }
}
