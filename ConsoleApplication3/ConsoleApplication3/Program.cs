using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        static void Main(string[] args)
        {
            //C# Sharp Basic Exercises 
            //Exercitiu 1
            Console.WriteLine("Exercitiul 1");
            Console.WriteLine("Hello");
            Console.WriteLine("Bianca Huruba");
            Console.WriteLine("//////////////////////////////");

            //Exercitiu 2
            Console.WriteLine("Exercitiul 1");
            int a = 6;int b = 2;
            Console.WriteLine(a+"+"+b+"=" + (a + b));
            Console.WriteLine("//////////////////////////////");

            //Exercitiu 3
            Console.WriteLine("Exercitiul 3");
            int x = 6; int y = 2;
            Console.WriteLine(x + ":" + y + "=" + (x / y));
            Console.WriteLine("//////////////////////////////");

            //Exercitiu 4
            Console.WriteLine("Exercitiul 4");
            Console.WriteLine("-1 + 4 * 6 =" + (-1 + 4 * 6));
            Console.WriteLine("( 35+ 5 ) % 7 ="+((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11= "+(14 + ((-4 * 6) / 11)));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2="+(2 + ((15 / 6) * 1) - (7 % 2)));
            Console.WriteLine("//////////////////////////////");

            ////Exercitiu 5
            Console.WriteLine("Exercitiul 5");
            int c;int d; int swap;
            Console.WriteLine("Input the First Number :");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number :");
            d = int.Parse(Console.ReadLine());
            swap = c;
            c = d;
            d = swap;
            Console.WriteLine("After swapping:");
            Console.WriteLine("First Number :"+c);
            Console.WriteLine("Second Number :"+d);
            Console.WriteLine("//////////////////////////////");

            ////Exercitiu 6
            Console.WriteLine("Exercitiul 6");
            int n1, n2, n3;
            Console.WriteLine("Input the first number to multiply:");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");
            n3= int.Parse(Console.ReadLine());
            Console.WriteLine(n1+"*"+n2+"*"+n3+"="+(n2*n3*n1));
            Console.WriteLine("//////////////////////////////");

            //Exercitiu 7
            Console.WriteLine("Exercitiul 7");
            int n11,n21;
            Console.WriteLine("Input the first number");
            n11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            n21 = int.Parse(Console.ReadLine());
            Console.WriteLine(n11+"+"+n21+"="+(n11+n21));
            Console.WriteLine(n11 + "-" + n21 + "=" + (n11 - n21));
            Console.WriteLine(n11 + "*" + n21 + "=" + (n11 * n21));
            Console.WriteLine(n11 + "/" + n21 + "=" + (n11 / n21));
            Console.WriteLine(n11 + "%" + n21 + "=" + (n11 % n21));
            Console.WriteLine("//////////////////////////////");

            ////Exercitiu 8
            Console.WriteLine("Exercitiul 8");
            int number;
            Console.WriteLine("Input the number:");
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 11; j++)
            {
                Console.WriteLine(number + "*" + j + "=" + (number * j));

            }
            Console.WriteLine("//////////////////////////////");

            ////Exercitiu 9
            Console.WriteLine("Exercitiul 9");
            double nr1, nr2, nr3, nr4;
            Console.WriteLine("Enter the First number");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the four number");
            nr4 = int.Parse(Console.ReadLine());
            double resoult = ((nr1 + nr2 + nr3 + nr4) / 4);
            Console.WriteLine("The average is:" + resoult);
            Console.WriteLine("//////////////////////////////");

            //Exercitiul 10
            Console.WriteLine("Exercitiul 10");
            double nr11, nr12, nr13;
            Console.WriteLine("Enter the First number");
            nr11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            nr12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            nr13 = int.Parse(Console.ReadLine());
            Console.WriteLine("("+nr11+"+"+nr12+")"+"·"+nr13+"="+((nr11+nr12)*nr13));
            Console.WriteLine(nr11+"*"+nr12+"+"+nr12+"*"+nr13+"="+(nr11*nr12+(nr12*nr13)));
            Console.WriteLine("//////////////////////////////");

            //Exercitiul 11
            Console.WriteLine("Exercitiul 11");
            Console.WriteLine("//////////////////////////////");
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look younger than {0}",age);
            Console.WriteLine("//////////////////////////////");

            //Exercitiul 12
            Console.WriteLine("Enter a number");
            int abc;
            abc = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++) {
                Console.Write(abc);
                Console.Write(" ");
            }
            Console.WriteLine("");
            for (int i2 = 0; i2 < 4; i2++)
            {
                Console.Write(abc);
            }
            Console.WriteLine("");
            Console.Write("{0} {0} {0} {0}",abc);
            Console.WriteLine("");
            Console.Write("{0}{0}{0}{0}", abc);
            Console.WriteLine("//////////////////////////////");

            //Exercitiul 13
            Console.WriteLine("Exercitiul 13");
            int q;
            Console.WriteLine("Enter a number:");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}",q);
            Console.WriteLine("{0} {0}",q);
            Console.WriteLine("{0} {0}",q);
            Console.WriteLine("{0} {0}",q);
            Console.WriteLine("{0}{0}{0}",q);
            Console.WriteLine("//////////////////////////////");

            //Exercitiul 14
            Console.WriteLine("Exercitiul 14");
            Console.Write("Enter the amount of celsius: ");
            int celsius;
            celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.WriteLine("//////////////////////////////");


            Console.Read();
            Console.ReadKey();
        }
    }
}
