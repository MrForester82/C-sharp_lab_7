using System;

namespace C_sharp_lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person gregor = new Person("Dorryson", "student");

            gregor.Age = 22;
            gregor.Salary = 89000.00F;
            gregor.setHealth("like a rhino");

            Console.WriteLine(gregor.Fam);
            Console.WriteLine(gregor.Age);
            Console.WriteLine(gregor.Status);
            Console.WriteLine(gregor.getHealth());
            //Console.WriteLine(gregor.getSalary());

            Console.WriteLine();

            Rational num1 = new Rational(-9, 4);
            num1.printRational();

            Rational num2 = new Rational(0, 4);

            Rational num3 = new Rational(2, 5);
            num3.printRational();

            Rational num4 = new Rational(2, 5);
            Console.WriteLine();

            (num1 + num3).printRational();

            (num1 - num3).printRational();

            (num1 * num3).printRational();

            (num1 / num3).printRational();

            Console.WriteLine(num1 == null);

            Console.WriteLine(num3 == num4);

            Console.WriteLine(num1 > num3);

            Console.WriteLine(num1 < num3);

            Console.WriteLine(new Rational(87, 88) < new Rational(86, 87));

            Console.WriteLine(num1 > 3.14F);

            Console.WriteLine(3.14F < num3);
        }
    }
}
