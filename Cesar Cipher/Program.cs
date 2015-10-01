using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            int numPlaces;
            Console.WriteLine("Please enter the message that you want to encode using cesar cipher.");
            string message = Console.ReadLine();
            Console.WriteLine("Please enter the number of places you want each letter to be moved by.");
            Int32.TryParse(Console.ReadLine(), out numPlaces);

            char[] messageArray = message.ToCharArray();
            char[] newAlphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                newAlphabet[i] = alphabet[i + numPlaces];
                if (newAlphabet[i] > 26)
                {
                    newAlphabet[i] = newAlphabet[i-26];
                }
            }
            Console.WriteLine("Your encoded message is: " + newAlphabet);
        }
    }
}
