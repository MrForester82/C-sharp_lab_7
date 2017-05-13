using System;
using System.Numerics;

namespace C_sharp_lab_7
{
    class Rational
    {
        private BigInteger divided;
        private BigInteger m;
        private BigInteger n;

        public Rational(BigInteger a, BigInteger b)
        {
            if(a > 0 && b > 0)
            {
                commonDivisor(ref a, ref b);
                makeDivided(ref a, b);
                m = a;
                n = b;
                //Console.WriteLine("{0}\t{1}/{2}", divided, m, n);
            }
            else
            {
                Console.WriteLine("Числитель и знаменатель должны быть больше нуля, иначе что я тут делаю??");
            }
        }

        public void commonDivisor(ref BigInteger a, ref BigInteger b)
        {
            BigInteger divisor = BigInteger.GreatestCommonDivisor(a, b);
            a /= divisor;
            b /= divisor;
        }

        public void makeDivided(ref BigInteger a, BigInteger b)
        {
            if (a > b)
            {
                divided = a / b;
                a = a % b;
            }
        }

        public override string ToString()
        {
            if(divided == 0)
                return m.ToString() + '/' + n.ToString();
            else
                return divided.ToString() + '(' + m.ToString() + '/' + n.ToString() + ')';
        }

        public void printRational()
        {
            Console.WriteLine(ToString());
        }
    }
}
