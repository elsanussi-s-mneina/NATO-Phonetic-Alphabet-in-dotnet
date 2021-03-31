using System.Collections.Generic;

namespace NATOPhoneticAlphabet
{
    public static class NATOPhoneticAlphabet
    {
        public static string SpellLetter(char input)
        {
            switch (input)
            {
                case 'a': case 'A': return "Alpha";
                case 'b': case 'B': return "Bravo";
                case 'c': case 'C': return "Charlie";
                case 'd': case 'D': return "Delta";
                case 'e': case 'E': return "Echo";
                case 'f': case 'F': return "Foxtrot";
                case 'g': case 'G': return "Golf";
                case 'h': case 'H': return "Hotel";
                case 'i': case 'I': return "India";
                case 'j': case 'J': return "Juliett";
                case 'k': case 'K': return "Kilo";
                case 'l': case 'L': return "Lima";
                case 'm': case 'M': return "Mike";
                case 'n': case 'N': return "November";
                case 'o': case 'O': return "Oscar";
                case 'p': case 'P': return "Papa";
                case 'q': case 'Q': return "Quebec";
                case 'r': case 'R': return "Romeo";
                case 's': case 'S': return "Sierra";
                case 't': case 'T': return "Tango";
                case 'u': case 'U': return "Uniform";
                case 'v': case 'V': return "Victor";
                case 'w': case 'W': return "Whiskey";
                case 'x': case 'X': return "X-ray";
                case 'y': case 'Y': return "Yankee";
                case 'z': case 'Z': return "Zulu";
                case ' ': case '\n': case '\r': return "(whitespace)";
                default: return input.ToString(); // Do not change unrecognized input
            };
        }

        public static string SpellText(string inputText)
        {
            List<string> spellings = new List<string>();

            for (int i = 0; i < inputText.Length; i++)
            {
                string spelling = SpellLetter(inputText[i]);
                spellings.Add(spelling);

            }

            string output = string.Join(' ', spellings.ToArray());
            return output;
        }
    }
}
