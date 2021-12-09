using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskas rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitjat.


            Random rnd = new Random();
                        
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on vooru võitnud ja saab punkti. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on vooru võitnud ja saab punkti.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik! Kumbki ei saa punkti.");
                }
            }
            Console.WriteLine($"Mängijal on {userScore} punkti, arvutil {cpuScore} punkti.");

            if (userScore > cpuScore)
            {
                Console.WriteLine("Mängija on võitnud, palju õnne!");
            }
            else
            {
                Console.WriteLine("Arvuti on võitnud.");
            }

            

        }
    }
}
