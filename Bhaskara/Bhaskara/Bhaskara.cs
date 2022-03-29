using System;

namespace Bhaskara
{
    public class Bhaskara
    {
        private int a, b, c;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public double calculaDelta()
        {
            double delta = (b * b) - 4 * a * c;
            return delta;
        }

        public double calculaRaizPositiva(double delta)
        {
            double rp = (-b + Math.Sqrt(delta)) / (2 * a);
            return rp;
        }

        public double calculaRaizNegativa(double delta)
        {
            double rn = (-b - Math.Sqrt(delta)) / (2 * a);
            return rn;
        }
    }
}
