using System;
using System.Collections.Generic;



namespace Primes
{

    class Program
    {

        
        static int tryprime = 3;
        static List<int> primeint;
        static bool temp = false;



        static void Main(string[] args)
        {
            Console.WriteLine("press enter to start calculating for the first time...");
            Console.WriteLine("press backspace to continue calculating");
            Console.WriteLine("press esc to exit...");

            ConsoleKeyInfo start = Console.ReadKey();
            if(start.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            if(start.Key == ConsoleKey.Enter)
            {
                primeint = new List<int>();
                next();
            }
            if(start.Key == ConsoleKey.Backspace)
            {
                List <string> primestring = new List<String>(System.IO.File.ReadAllLines(@"D:\Age Klopstra\Documents\priemgetallen.txt"));
                primeint = primestring.ConvertAll(int.Parse);
                tryprime = primeint[primeint.Count - 1];
                next();
            }
    }
        public static void next()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\Age Klopstra\Documents\priemgetallen.txt"))
            {
                for (int z = 0; z < 1; z = 0)
                {
                        if (tryprime % 3 == 0)
                        {
                            tryprime += 2;
                            continue;
                        }

                        else if (tryprime % 5 == 0)
                        {
                            tryprime += 2;
                            continue;
                        }
                        else if (tryprime % 7 == 0)
                        {
                            tryprime += 2;
                            continue;
                        }


                        for (int x = 0; x < primeint.Count; x++)
                        {
                            if (tryprime % primeint[x] == 0)
                            {

                                temp = true;
                                break;
                            }
                        }
                        if (temp)
                        {
                            tryprime += 2;
                            temp = false;
                            continue;
                        }


                        primeint.Add(tryprime);
                        Console.WriteLine(tryprime.ToString());
                        file.Write(tryprime + Environment.NewLine);
                        tryprime += 2;
                        continue;
                }
            }
        }
    }
}
