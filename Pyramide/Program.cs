/*
    Author:     Niklas Schäfer
    Date:       20.09.2016
    Summary:    Langeweile - For Schleifen werden
                wir eh noch kennen lernen
 */
using System;
using System.Linq;

namespace Pyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            realMain();
        }

        static void realMain()
        {
            Console.Write("Select your methods! 1 or a = deineMutter(int) || 2 or b = deinVater(int)");
            string answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "1":
                case "a":
                    Console.Write("Give me numbers: ");
                    try
                    {
                        int mHeight = Convert.ToInt32(Console.ReadLine());
                        deineMutter(mHeight);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        realMain();
                    }
                    break;

                case "2":
                case "b":
                    Console.Write("Give me numbers: ");
                    try
                    {
                        int vHeight = Convert.ToInt32(Console.ReadLine());
                        deinVater(vHeight);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        realMain();
                    }
                    break;

                default:
                    Console.WriteLine("No method selected! Selecting default!\n"
                                      + "Give me numbers: ");
                    try
                    {
                        int dHeight = Convert.ToInt32(Console.ReadLine());
                        deineMutter(dHeight);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        realMain();
                    }

                    break;
            }
        }
        /*
         Deklaration  || Bedingung || Danach
         int ebene = 1 || Solange ebene kleiner oder gleich height || ebene + 1


         Deklaration || Kombiniere(string,Wiederhole(string,anzahl));
         Erzeuge string stern = kombiniere mehrere Strings("Whitespace", Wiederhole("*", ebene));
         Do(string.PadLeft(number);

         Wir ziehen von den Reihen die wir erstellen sollen, die gerade erstelle ab und fügen die Länge vom string stern hinzu
         Number = height - ebene + string.Länge 


         Schreibe(stern.Rechtsbündig(height - ebene + stern.Länge));
        */
        static void deineMutter(int height)
        {
            for (int ebene = 1; ebene <= height; ebene++)
            {
                string stern = string.Join(" ", Enumerable.Repeat("*", ebene));
                Console.WriteLine(stern.PadLeft(height - ebene + stern.Length));
            }
            realMain();
        }
        /*
         count = 1
         solange(lines = height; lines größer oder gleich 1; lines -1)
            solange(whitespaces = lines -1; whitespaces kleiner oder grö0er 1; whitespaces -1)
                Schreib("Whitespace");
            solange(stern = 1; stern kleiner oder gleich count; stern +1)
                Schreib("*");
                schreib("Whitespace");
            count + 1
            Schreib(Neue Zeile);
         */
        static void deinVater(int height)
        {
            int count = 1;
            for (int lines = height; lines >= 1; lines--)
            {
                for (int whitespaces = lines - 1; whitespaces >= 1; whitespaces--)
                {
                    Console.Write(" ");

                }
                for (int stern = 1; stern <= count; stern++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                count++;
                Console.Write(Environment.NewLine);
            }
            realMain();
        }
    }
}