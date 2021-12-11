using System;


namespace FigureArea
{
    abstract class Figure
    {
        public static double s;
        public string[] NameFigure;
        public string[] namefigure
        {
            get { return namefigure; }
            set { namefigure = value; }
        }
        public Figure(string str1, string str2)
        {
            str1 = "Треугольник";
            str2 = "Круг";
            string[] Namefigure = new string[] { str1, str2 };
            namefigure = Namefigure;
        }
        public abstract double FigureArea(double t,double r,double s);

    }
     class Сircle : Figure
    {
        public string field
        { get; set; }
        public Сircle(string str1, string str2)
            : base(str1, str2)
        {
            field = namefigure[1];
        }
        public override double FigureArea(double r,double r1,double pi )
        {
            
            if (field == namefigure[1])
            {
                s = pi * r1 * r;
            }
            return s;

            // S = 3,14 * R*R - круг 
        }
    }

    class Triangle : Figure
    {
        public string field
        { get; set; }
        public Triangle(string str1, string str2)
            : base(str1, str2)
        {
            field = namefigure[1];
        }
        public override double FigureArea(double a,double b,double c)
        {
            double hypotenuse = a;
            double leg1 = b;
            double leg2 = c;
            if (a < b)
            {
                hypotenuse = b;
                leg1 = a;
            }
            else if (a < c)
            {
                hypotenuse = c;
                leg2 = a;
            }
            if(hypotenuse*hypotenuse==leg1*leg1+leg2*leg2)
            {
                return leg2 * leg1 / 2;
            }
            double p = (a + b + c) / 2;
           
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
