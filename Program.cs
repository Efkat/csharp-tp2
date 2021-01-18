using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP2.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer1 = new Timer();

            //Cast
            uint v_uint = 4;
            ulong v_ulong = 1400;
            v_uint = (uint)v_ulong;

            Console.WriteLine("Saisissez l'exercice souhaité : ");
            
            int number = Console.Read() - 48;

            switch (number)
            {
                case 1:
                    byte[] numberArray = { 7, 8, 9 };
                    byte[] numberArray2 = { 0, 1, 2, 3, 4 };
                    for (byte index = 0; index < 10; index++)
                    {
                        if (numberArray.Contains(index) || numberArray2.Contains(index))
                        {
                            Console.WriteLine("Numéro {0}", index);
                        }
                        else continue;
                    }
                    break;
                case 2:
                    string userInput;
                    do
                    {
                        Console.WriteLine("Saisissez du texte : ");
                        userInput = Console.ReadLine();
                    } while (userInput.StartsWith("a"));
                    break;
                case 3:
                    string[] days = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
                    foreach(string day in days)
                    {
                        Console.WriteLine(day);
                    }
                    break;
                default:
                    Console.WriteLine("Exercice non réalisé !");
                    break;
            }

            Console.ReadLine();
        }
    }
}
