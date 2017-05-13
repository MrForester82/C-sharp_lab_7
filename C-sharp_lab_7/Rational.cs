﻿using System;
using System.Numerics;

namespace C_sharp_lab_7
{
    class Rational
    {
        private BigInteger divided;
        private BigInteger m;
        private BigInteger n;
        private BigInteger sign;

        public Rational(BigInteger a, BigInteger b)
        {
            if(a != 0 && b != 0)
            {
                if(a * b < 0)
                {
                    sign = -1;
                }
                else
                {
                    sign = 1;
                }
                if (a < 0)
                    a *= -1;
                if (b < 0)
                    b *= -1;
                
                commonDivisor(ref a, ref b);
                makeDivided(ref a, b);
                m = a;
                n = b;

            }
            else
            {
                Console.WriteLine("Числитель и знаменатель не должны быть равны нулю, иначе что я тут делаю??");
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

        public static BigInteger listCommonMultiple(BigInteger a, BigInteger b)
        {
            return a * b / BigInteger.GreatestCommonDivisor(a, b);
        }

        public static Rational operator+(Rational left, Rational right)
        {
            BigInteger totalDivisor = listCommonMultiple(left.n, right.n);
            BigInteger additionalLeft = totalDivisor / left.n;
            BigInteger additionalRight = totalDivisor / right.n;
            BigInteger newM = left.sign * (left.m + left.divided * left.n) * additionalLeft + right.sign * (right.m + right.divided * right.n) * additionalRight;
            return new Rational(newM, totalDivisor);
        }

        public static Rational operator -(Rational left, Rational right)
        {
            BigInteger totalDivisor = listCommonMultiple(left.n, right.n);
            BigInteger additionalLeft = totalDivisor / left.n;
            BigInteger additionalRight = totalDivisor / right.n;
            BigInteger newM = left.sign * (left.m + left.divided * left.n) * additionalLeft - right.sign * (right.m + right.divided * right.n) * additionalRight;
            return new Rational(newM, totalDivisor);
        }

        public static Rational operator *(Rational left, Rational right)
        {
            return new Rational(left.sign * (left.m + left.divided * left.n) * right.sign * (right.m + right.divided * right.n), left.n * right.n);
        }

        public static Rational operator /(Rational left, Rational right)
        {
            Rational reverseRight = new Rational(right.n * right.sign, right.m + right.n * right.divided);
            reverseRight.printRational();
            return new Rational((left * reverseRight).m + (left * reverseRight).divided * (left * reverseRight).n, (left * reverseRight).n * (left * reverseRight).sign);
        }

        public override string ToString()
        {
            if (divided == 0)
            {
                if (sign == 1)
                {
                    return m.ToString() + '/' + n.ToString();
                }
                else
                {
                    return '-' + m.ToString() + '/' + n.ToString();
                }
            }
            else
            {
                if (sign == 1)
                {
                    return divided.ToString() + '(' + m.ToString() + '/' + n.ToString() + ')';
                }
                else
                {
                    return '-' + divided.ToString() + '(' + m.ToString() + '/' + n.ToString() + ')';
                }
            }
                
        }

        public void printRational()
        {
            Console.WriteLine(ToString());
        }
    }
}
