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
            int number = 0;

            Console.WriteLine("Saisissez l'exercice souhaité : ");
            number = Convert.ToInt32(Console.ReadLine());

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
                case 4:
                    goto exercice4;
                default:
                    Console.WriteLine("Exercice non réalisé !");
                    break;
            }

        exercice4:
            int numberInput = 0;
            int sum = 0;

            do
            {
                try
                {
                    Console.Write("Taper un chiffre : ");
                    numberInput = Convert.ToInt32(Console.ReadLine());
                    sum += numberInput;
                    if (numberInput < 50)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Le chiffre saisie doit être minimum égale à 50 !");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Veuillez saisir un chiffre valide !");
                }
                finally
                {
                    if(sum >= 50)
                    {
                        Console.WriteLine("La somme a atteint 50 minimum, bravo");
                    }
                    Console.WriteLine("La somme totale est de {0}", sum);
                }
            } while (sum < 50);

            

            
        }
    }
}
