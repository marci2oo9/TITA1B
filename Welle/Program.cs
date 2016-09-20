/*
    
    Author:     Niklas Schäfer
    Date:       20.09.2016
    Summary:    Erste wirklich Aufgabe in
                Programmieren bei Herr Loer
 */
using System;
using System.Linq;

namespace Welle
{
    class Program
    {
        static void Main(string[] args)
        {
            realMain();
        }

        static void realMain()
        {
            float d1, d2, l1, l2, r1, r2, vol1, vol2, volall, mass1, mass2, massall, dichte;
            dichte = 7.8f;

            Console.Write("\tPlease enter d1: ");
            d1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("\tPlease enter l1: ");
            l1 = Convert.ToSingle(Console.ReadLine());

            r1 = d1 / 2;
            vol1 = Convert.ToSingle(Math.PI * Math.Pow(r1, 2) * l1);
            mass1 = dichte * vol1;

            Console.Write("\tPlease enter d2: ");
            d2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("\tPlease enter l2: ");
            l2 = Convert.ToSingle(Console.ReadLine());

            r2 = d2 / 2;
            vol2 = Convert.ToSingle(Math.PI * Math.Pow(r2, 2) * l2);
            mass2 = dichte * vol2;

            volall = (vol2 * 2) + vol1;
            massall = (mass2 * 2) + mass1;

            Console.Write("\tDas Gesamtvolumen beträgt {0}mm³\n"
                           + "\tDie Gesamtmasse beträgt {1}kg\n"
                           + "\tWiederholen? (Y)es (N)o\n\t", volall, massall);

            string answer = Console.ReadLine();
            if(answer.ToLower().FirstOrDefault() == 'y')
            {
                realMain();
            }
        }
    }
}
