using System;
using static NATOPhoneticAlphabet.NATOPhoneticAlphabet;

namespace NATOPhoteicAlphabet_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NATO Phonetic Alphabet Application");
            Console.WriteLine("Write some text and press enter,");
            Console.WriteLine("and it will be spelled out.");

            while (true)
            {
                var input = Console.ReadLine();
                if (input != null)
                {
                    string output = SpellText(input);
                    Console.WriteLine(output);
                }
            }
        }
    }
}
