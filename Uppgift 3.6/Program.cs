using System;

namespace Uppgift3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt förnamn först och därefter ditt efternamn");
            string förnamn = Console.ReadLine();
            string efternamn = Console.ReadLine();

            if (förnamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine(förnamn + " kommer före " + efternamn + " i bokstavsordning");
            }
            else
            {
                Console.WriteLine(efternamn + " kommer före " + förnamn + " i bokstavsordning");
            }
        }
    }
}