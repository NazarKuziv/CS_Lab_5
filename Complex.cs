using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_5
{
    public class Complex
    {
        private double x;
        private double y;

        public double Get_x()  { return x; }
        public double Get_y()  { return y; }
        public void Set_x(double value) { x = value; }
        public void Set_y(double value) { y = value; }
        public Complex(){x = 0;y = 0;}
        public Complex(double value_x, double value_y){this.x = value_x; this.y = value_y;}
        public Complex(Complex c){this.x = c.x;this.y = c.y;}
        //

        public  Complex Subtraction(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }
        public  Complex Division(Complex a, Complex b)
        {
            double r1 = a.x;
            double i1 = a.y;
            double r2 = b.x;
            double i2 = b.y;
            Complex t = new Complex((r1 * r2 - i1 * i2) / (r2 * r2 + i2 * i2), (-r1 * i2 + i1 * r2) / (r2 * r2 + i2 * i2));
            t.y = Math.Round(t.y, 2);
            t.x = Math.Round(t.x, 2);
            return t;
        }
        public  Complex Conj(Complex a)
        {
            return new Complex(a.x, a.y * -1);
        }
        public bool Comparison1(Complex a, Complex b)
        {
            bool test = false;
            if(a.x == b.x && a.y==b.y)
                test = true;

            return test;
        }
        //
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - a.y * b.y, a.x * b.x + a.y * b.x);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double r1 = a.x;
            double i1 = a.y;
            double r2 = b.x;
            double i2 = b.y;
            Complex t = new Complex((r1 * r2 - i1 * i2) / (r2 * r2 + i2 * i2), (-r1 * i2 + i1 * r2) / (r2 * r2 + i2 * i2));
            t.y = Math.Round(t.y, 2);
            t.x = Math.Round(t.x, 2);
            return t;
        }

        public static Complex operator ^(Complex a, int n)
        {
            var y = new Complex(1, 0);
            for (int i = 1; i <= n; i++)
                y = y * a;
            return y;
        }
        public static Complex operator ++(Complex a)
        {
            a.x++;
            a.y++;
            return a;
        }
        public static Complex operator --(Complex a)
        {
            a.x--;
            a.y--;
            return a;
        }
        public override string ToString()
        {
            if (this.y < 0)
                return  this.x + " " + this.y + "і";
            else
                return this.x + "+" + this.y + "і";
        }

    }
}
