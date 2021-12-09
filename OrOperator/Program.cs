using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm käsib kasutajal sisestada kasutajatunnusja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna "admin1234"
            //siis konsoolis kuvatakse "Tere tulemas!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //OR (või) || (pipes)

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
