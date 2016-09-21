/*
    Author:     Niklas Schäfer
    Date:       21.09.2016
    Summary:    Hausaufgaben
 */
using System;
using System.Collections.Generic;

namespace Kegel
{
    class Program
    {
        static void Main(string[] args)
        {
            realMain();
        }
        /*
            Mimimi
          
            berechnung[0] = Radius; 
            berechnung[1] = Höhe; 
            berechnung[2] = Seitenlinie;
            berechnung[3] = Grundfläche;  
            berechnung[4] = Mantelfläche;
            berechnung[5] = Oberfläche;
            berechnung[6] = Volumen;


            s = Math.Sqrt(Math.Pow(Höhe,2) + Math.Pow(Radius,2));
            G = Math.PI * Math.Pow(Radius,2);
            M = Math.PI * Radius * s;
            O = G + M
            V = 1.00 / 3.00 * Math.PI * Math.Pow(Radius,2) * Höhe;
         */
        static void realMain()
        {
            List<double> berechnung = new List<double>();


            Console.Write("\tPlease enter your radius: ");
            berechnung.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("\tPlease enter your height: ");
            berechnung.Add(Convert.ToDouble(Console.ReadLine()));

            berechnung.Add(Math.Sqrt(Math.Pow(berechnung[0], 2) + Math.Pow(berechnung[1], 2)));
            berechnung.Add(Math.PI * Math.Pow(berechnung[0], 2));
            berechnung.Add(Math.PI * berechnung[0] * berechnung[2]);
            berechnung.Add(berechnung[3] + berechnung[4]);
            berechnung.Add(1.00 / 3.00 * Math.PI * Math.Pow(berechnung[0], 2) * berechnung[1]);

            Console.WriteLine("\tDas Volumen beträgt: {0} cm³\n"
                            + "\tDie Oberfläche beträgt: {1} cm²\n\t", berechnung[6], berechnung[5]);
            Console.ReadLine();
        }
    }
}
