using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assprobas
{
    class Program
    {
        static public float ConversionCeltoFar(float a)
        {
            float x = a * 9/5 + 32;
            return x;
            
        }
        static public float ConversionFartoCel(float b)
        {
            float y = (b - 32) * 5/9;
            return y;
        }
        static public float ConversionEUtoUs(float c)
        {
            float w= c * 378000/1609;
            return w;
        }
        static public float ConversionUstoEU(float d)
        {
            float z = d * 1609 / 378000;
            return z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do: \n1.Compare two temperatures \n2.Convert your gas consumption");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Celsius Value:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Fahrenheit Value:");
                float b = float.Parse(Console.ReadLine());
                float c = ConversionCeltoFar(a);
                float d = ConversionFartoCel(b);
                if (a > d)
                {
                    float diffy = a - d;
                    float diffy2 = c - b;
                    Console.WriteLine(a + " Celsius is greater than" + " " + b + " " + "Fahrenheits by" + " " + diffy + " " + "Celsius degrees and" + " " + +diffy2 + " " + "Fahrenheit degrees");
                    Console.WriteLine(b);
                    Console.WriteLine(d);
                    Console.WriteLine(c);
                }
                else if (a < d)
                {
                    float diffr = d - a;
                    float diffn = b - c;
                    Console.WriteLine(b + "" + " Fahrenheit is greater than" + " " + a + " " + "Celsius by" + " " + diffr + " " + "Celsius degrees and" + " " + diffn + " " + "Fahrenheit degrees");
                }
                else
                {
                    Console.WriteLine("Both are equal");
                }
            }
            else if (choice==2)
            {
                Console.WriteLine("Do you need \n a.miles per gallons to kilometer per liter conversion \n b.kilometer per liter to miles per gallons conversion  ");
                string choice2 = Console.ReadLine();
                if (choice2=="a")
                {
                    Console.WriteLine("Enter the miles per gallons value you want to convert");
                    float value1 = float.Parse(Console.ReadLine());
                    float result1 = ConversionUstoEU(value1);
                    Console.WriteLine(result1);
                }
                else if (choice2=="b")
                {
                    Console.WriteLine("Enter the miles per gallons value you want to convert");
                    float value2 = float.Parse(Console.ReadLine());
                    float result2 = ConversionEUtoUs(value2);
                    Console.WriteLine(result2);

                }
                else
                {
                    Console.WriteLine("Please answer with a or b");
                }
            }
            else
            {
                Console.WriteLine("Please choose between 1. and 2.");
            }
        }
    }
}
