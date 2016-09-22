using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berechnung
{
    class Program
    {
        /*
         * Qa = Quader a 
         * Qb = Quader b
         * Qh = Quader Höhe
         * Qv = Quader Volumen
         * Qg = Quader Grundfläche
         * Qo = Quader Oberfläche
         */
        static void Main(string[] args)
        {
            char repeat = 'y';

            while(repeat == 'y')
            {

                Console.Write("\tWas möchtest du berechnen? 1: Rechtecksäule 2: Zylinder  ");
                var answer = Console.ReadLine();

                if (answer == "1")
                {
                    double Qa, Qb, Qh, Qv, Qg, Qo;


                    Console.Write("\t========Rechtecksäule========\n"
                                     + "\tPlease enter a [cm]: ");
                    Qa = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\tPlease enter b [cm]: ");
                    Qb = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\tPlease enter the height [cm]: ");
                    Qh = Convert.ToDouble(Console.ReadLine());

                    Qg = Qa * Qb;
                    Qv = Qa * Qb * Qh;
                    Qo = 2 * Qa * Qb + 2 * Qa * Qh + 2 * Qb * Qh;

                    Console.Write("\tVolume : {0}\n"
                                 + "\tSurface : {1}\n", Qv, Qo);

                    Console.Write("\tWanna repeat? ");

                    string moep = Console.ReadLine();
                    if (moep.ToLower().FirstOrDefault() == 'n')
                    {
                        repeat = 'n';
                    }

                }
                else
                {

                    double Zr, Zh, Zd, Zu, Zg, Zm, Zo, Zv;


                    Console.Write("\t========Zylinder========\n"
                                     + "\tPlease enter r [cm]: ");
                    Zr = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\tPlease enter h [cm]: ");
                    Zh = Convert.ToDouble(Console.ReadLine());

                    Zd = 2 * Zr;
                    Zu = 2 * Math.PI * Zr;
                    Zg = Math.PI * Math.Pow(Zr, 2);
                    Zm = 2 * Math.PI * Zr * Zh;
                    Zo = Zg + Zm;
                    Zv = Math.PI * Math.Pow(Zr, 2) * Zh;


                    Console.Write("\tVolume: {0}cm³\n"
                                 + "\tSurface: {1}cm²\n", Zv, Zo);

                    Console.Write("\tWanna repeat? ");

                    string moep = Console.ReadLine();
                    if (moep.ToLower().FirstOrDefault() == 'n')
                    {
                        repeat = 'n';
                    }
                }

            }
        }


    }
}
