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
            ////Ex1
            //Console.WriteLine("Exercitiul 1");
            //char letter11, letter12, letter13;
            //Console.WriteLine("Enter letter:");
            //letter11 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter letter:");
            //letter12 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter letter:");
            //letter13 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Output: {0} {1} {2}", letter13, letter12, letter11);
            //Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////
            ////Ex2
            //Console.WriteLine("Exercitiul 2");
            //int number21, width, height;
            //Console.WriteLine("Enter number:");
            //number21 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter width:");
            //width = Convert.ToInt32(Console.ReadLine());
            //height = width;
            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write(number21);
            //    }
            //    Console.WriteLine();
            //    width--;
            //}
            //Console.WriteLine("////////////////////////////////////////////////");
            //////////////////////////////////////////////////////////
            ////Ex3
            //Console.WriteLine("Exercitiul 3");
            //string user, password;
            //int control = 0;
            //int flag = 0;
            //do
            //{
            //    Console.WriteLine("Default username=username and password=password");
            //    Console.WriteLine("Input a username:");
            //    user = Console.ReadLine();
            //    Console.WriteLine("Input a password:");
            //    password = Console.ReadLine();

            //    if (user == "username" && password == "password")
            //    {
            //        flag = 1;
            //        control = 3;
            //    }
            //    else
            //    {
            //        flag = 0;
            //        control++;
            //    }
            //} while ((user != "username" || password != "password") && control != 3);
            //if (flag == 0)
            //{
            //    Console.WriteLine("Login attemp more than three times. Try later!");
            //}
            //else {
            //    if (flag == 1) {
            //        Console.WriteLine("Entered successfull!");
            //    }
            //        }
            //Console.WriteLine("////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////
            ////Ex4
            Console.WriteLine("Ex4");
            int number41, number42;
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
            else if ('+'==operation)
            {
                Console.WriteLine("{0} + {1} = {2}", number41, number42, (number41 + number42));
            }
            else if ('x'==operation)
            {
                Console.WriteLine("{0} x {1} = {2}", number41, number42, (number41 * number42));
            }
            else if (':'==operation)
            {
                Console.WriteLine("{0} : {1} = {2}", number41, number42, (number41 / number42));
            }
            else {
                Console.WriteLine("Invalid operation!");
            }
                Console.ReadKey();



        }
    }
}
