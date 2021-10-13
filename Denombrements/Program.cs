/**
* titre : Denombrements
* description : Permutation, arrangement ou combinaison
* auteur : Shekiladze Giorgi
* date création : 13/10/2021
* date dernière modification : 13/10/2021 17H
*/


using System;

namespace Denombrements
{
    class Program
    {
        static int saisie(string message, int borneMin, int borneMax)
        {
            //declarations
            int selection = 0;
            bool correct = false;
            //saisie du choix en nombre entier entre tel et tel valeur
            while (!correct || selection < borneMin || selection > borneMax)
            {
                try
                {
                    Console.Write(message + "(entre " + borneMin + " et " + borneMax + ") = ");
                    selection = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez votre choix");
                }
            }
            return selection;
        }

        static void Main(string[] args)
        {
            //declarations
            int c = 1, min = 0, max = 3;
            while (c != 0)
            {
                // Affichage du menu de selection et entree du choix
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                c = saisie("Choix", min, max);

                if (c == 0)
                {
                    //Arret du programme si le choix = 0
                    Environment.Exit(0);
                }
                Console.Read();
                if (c == 1)
                {
                    //Entree de valeur et permutation si choix = 1
                    int n = saisie("nombre total d'éléments à gérer", int.MinValue, int.MaxValue);
                    // calcul de r
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        //Saisie des valeurs et arrangement si choix = 2
                        int t = saisie("nombre total d'éléments à gérer", int.MinValue, int.MaxValue);
                        int n = saisie("nombre d'éléments dans le sous ensemble", int.MinValue, int.MaxValue);
                        // calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        //Saisie des valeurs et combinaison si choix = 3
                        int t = saisie("nombre total d'éléments à gérer", int.MinValue, int.MaxValue);
                        int n = saisie("nombre d'éléments dans le sous ensemble", int.MinValue, int.MaxValue);
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
