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

        }
    }
}
