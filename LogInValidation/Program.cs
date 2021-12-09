using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm käsib kasutajal sisestada kasutajatunnusja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna "admin1234"
            //siis konsoolis kuvatakse "Tere tulemas!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti. {3 - i} katset on jäänud");
                }
            }
        }
    }
}
