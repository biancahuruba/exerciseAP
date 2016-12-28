using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            Console.WriteLine("Exercitiul 1");
            char letter11, letter12, letter13;
            Console.WriteLine("Enter letter:");
            letter11 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter letter:");
            letter12 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter letter:");
            letter13 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Output: {0} {1} {2}", letter13, letter12, letter11);
            Console.WriteLine("////////////////////////////////////////////////");
            //////////////////////////////////////////////////////
            //Ex2
            Console.WriteLine("Exercitiul 2");
            int number21, width, height;
            Console.WriteLine("Enter number:");
            number21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());
            height = width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(number21);
                }
                Console.WriteLine();
                width--;
            }
            Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////
            //Ex3
            Console.WriteLine("Exercitiul 3");
            string user, password;
            int control = 0;
            int flag = 0;
            do
            {
                Console.WriteLine("Default username=username and password=password");
                Console.WriteLine("Input a username:");
                user = Console.ReadLine();
                Console.WriteLine("Input a password:");
                password = Console.ReadLine();

                if (user == "username" && password == "password")
                {
                    flag = 1;
                    control = 3;
                }
                else
                {
                    flag = 0;
                    control++;
                }
            } while ((user != "username" || password != "password") && control != 3);
            if (flag == 0)
            {
                Console.WriteLine("Login attemp more than three times. Try later!");
            }
            else
            {
                if (flag == 1)
                {
                    Console.WriteLine("Entered successfull!");
                }
            }
            Console.WriteLine("////////////////////////////////////////////////");
            //////////////////////////////////////////////////////
            //Ex4
            Console.WriteLine("Ex4");
            double number41, number42;
            char operation;
            Console.WriteLine("Enter a number:");
            number41 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can have the operations: +, -, x, : .");
            Console.WriteLine("Enter the operation:");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            number42 = Convert.ToInt32(Console.ReadLine());

            if ('-' == operation)
            {
                Console.WriteLine("{0} - {1} = {2}", number41, number42, (number41 - number42));
            }
            else if ('+' == operation)
            {
                Console.WriteLine("{0} + {1} = {2}", number41, number42, (number41 + number42));
            }
            else if ('x' == operation)
            {
                Console.WriteLine("{0} x {1} = {2}", number41, number42, (number41 * number42));
            }
            else if (':' == operation)
            {
                Console.WriteLine("{0} : {1} = {2}", number41, number42, (number41 / number42));
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }
            Console.WriteLine("////////////////////////////////////////////////");
            //////////////////////////////////////////////////////
            //Ex5
            Console.WriteLine("Ex5");
            double radius;
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area={0}", (radius * radius * Math.PI));
            Console.WriteLine("Perimeter={0}", (2 * radius * Math.PI));
            Console.WriteLine("////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////
            //Ex6
            Console.WriteLine("Ex6");
            int x, y;
            Console.WriteLine("Function: x= y^2 +2y+1");
            for (y = -5; y <= 5; y++)
            {
                Console.WriteLine("For y={0}, x={1}", y, (y * y) + (2 * y) + 1);
            }
            Console.WriteLine("////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////
            //Ex7
            Console.WriteLine("Ex7");
            float distance, hours, minutes, seconds;
            float timesec, mps, mph, kph;

            Console.WriteLine("The distance is:");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("The time in hours is:");
            hours = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("The time in minutes is:");
            minutes = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("The time in seconds is:");
            seconds = Convert.ToSingle(Console.ReadLine());

            timesec = (3600 * hours) + (60 * minutes) + seconds;
            mps = distance / timesec;
            kph = (distance / 1000.0f) / (timesec / 3600.0f);
            mph = kph / (1.609f);

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
            Console.WriteLine("////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////
            //Ex8
            Console.WriteLine("Ex8");
            double radiussf;
            Console.WriteLine("Enter radius:");
            radiussf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area={0}", (radiussf * radiussf * Math.PI * 4));
            Console.WriteLine("Volume={0}", (4 / 3 * (radiussf * radiussf * radiussf * Math.PI)));
            Console.WriteLine("////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////
            //Ex9
            Console.WriteLine("Ex9");
            char symbol;

            Console.WriteLine("Enter a symbol:");
            symbol = Convert.ToChar(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("{0} is a a lowercase vowel.", symbol);
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("{0} is a digit.", symbol);
            }
            else { Console.WriteLine("{0} it's another symbol.", symbol); }
            Console.WriteLine("////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////
            //Ex10
            Console.WriteLine("Ex10");
            int number101, number102;
            Console.WriteLine("Enter first number:");
            number101 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            number102 = Convert.ToInt32(Console.ReadLine());

            bool flag2;
            flag2 = (number101 % 2 == 0) && (number102 % 2 == 0) ? true : false;
            Console.WriteLine(flag2 ? "Numbers are both even" : "At least a number is odd.");
            Console.WriteLine("////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////
            //Ex11
            Console.WriteLine("Ex11");
            int number111, number, uc, rest;
            number111 = 0;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; number != 0; i++)
            {
                rest = number % 2;
                number = number / 2;
                number111 = number111 * 10 + rest;
            }
            Console.WriteLine(number111);
            Console.WriteLine("The binary form of the number is:");
            while (number111 != 0)
            {
                uc = number111 % 10;
                number111 = number111 / 10;
                Console.Write(uc);
            }

            Console.ReadKey();



        }
    }
}
