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
            int exerciceNumber = Console.Read();
            switch (exerciceNumber)
            {
                case 1:
                    goto Exercice1;
                case 2:
                    goto Exercice2;
                default:
                    Console.WriteLine("Exercice non réalisé !");
                    break;
            }

            Exercice1:
                byte[] numberArray = {7, 8, 9};
                byte[] numberArray2 = { 0,1,2,3,4};
                for (byte index = 0; index < 10; index++)
                {
                    if (numberArray.Contains(index) || numberArray2.Contains(index))
                    {
                        Console.WriteLine("Numéro {0}", index);
                    }
                    else continue;
                }

            Exercice2:
                string userInput;
                do
                {
                    Console.WriteLine("Saisissez du texte : ");
                    userInput = Console.ReadLine();
                } while (userInput.StartsWith("a"));

            Console.ReadLine();
        }
    }
}
