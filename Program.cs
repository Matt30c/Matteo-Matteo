using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice_matteo_matteo
{
    internal class Program
    {
       

public class MyProgram
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD

             Airetriangle(12, 54);
             bool boucle;
=======
            bool boucle;
            int nombreCalcul = 0; 
>>>>>>> ee903ba87756d22e246b6c0566fa8cd5f42c82f3

            boucle = true;
            while (boucle == true)
            {
                Console.WriteLine("quel operation veux tu faire ?(/,+,*,-,p = puissance,r = racines)");
                string operation;

                operation = Console.ReadLine();
                int n1 = 0;
                int n2 = 0;
                int op = 0;

                if (operation == "p")
                {
                    Console.WriteLine("choisi un numero");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    op = Puissance(n1);
                }
                else
                {
                    if (operation == "r")
                    {
                        Console.WriteLine("choisi un numero");
                        n1 = (int)inputValue();
                        op = Racine(n1);
                    }
                    else
                    {
                        Console.WriteLine("choisi deux numero");
                        n1 = (int)inputValue();
                        n2 = (int)inputValue();
                    }
                }
                if (operation == "/")
                {
                    op = n1 / n2;
                }
                if (operation == "+")
                {
                    op = n1 + n2;
                }
                if (operation == "-")
                {
                    op = n1 - n2;
                }
                if (operation == "*")
                {
                    op = n1 * n2;
                }
                Console.Write("la reponse est: ");
                Console.WriteLine(op);
                Console.WriteLine("veut tu faire une autre operation? ");
                string rep;

                    rep = Console.ReadLine();
                if (rep == "oui")
                {
                        nombreCalcul++;
                }
                else
                {
                    boucle = false;
                }
            }
                Console.WriteLine("vous avez fais "+nombreCalcul+" calculs");
                Console.WriteLine("programme fini");
        }

        public static int Puissance(int n1)
        {
            Console.WriteLine("choisi la puissance que tu veux faire");
            int np;

            np = (int)inputValue();
            int i;

            i = 0;
            int resultat;

            resultat = n1;
            for (i = 2; i <= np; i++)
            {
                resultat = resultat * n1;
            }

            return resultat;
        }

        public static int Racine(double n1)
        {
            int i;

            i = 0;
            int resultat;

            resultat = 0;
            while (i <= n1 && resultat == 0)
            {
                i = i + 1;
                if (i * i == n1)
                {
                    resultat = i;
                }
                else
                {
                    resultat = 0;
                }
            }
            if (resultat == 0)
            {
                Console.WriteLine("aucun nombre entier peut etre le resultat donc resultat = 0");
            }

            return resultat;
        }

        // .NET can only read single characters or entire lines from the
        // console. The following function safely reads a double value.
        /*private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }*/
        public static void Airetriangle(int basee, int hauteur)
        {
                int aire = (basee * hauteur) / 2;
                Console.WriteLine(aire);
        }
            
    }

    }
}

