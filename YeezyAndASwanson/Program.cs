using System;

namespace YeezyAndASwanson
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("One day, while walking in the woods you overhear a conversation...");
            Console.WriteLine("It's a conversation of such intense philosphical meaning that you can't stop from overheaing");
            string cont;
            do
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(YeezyQuote.YeezyYeets());
                    Console.WriteLine();
                    Console.WriteLine(SwanonWisdom.SwansonSpeaks());
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                }
                Console.WriteLine("Would you like to keep listening?");
                cont = Console.ReadLine().ToLower();
            } while (cont != "no");

            Console.WriteLine("With your mind sufficiently, blown you walk away a different person.");
        }
    }
}
