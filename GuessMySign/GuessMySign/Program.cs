using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMySign
{
    class Program
    {
        static void Main(string[] args)
        {
            //greeting 
            Console.WriteLine("Guess my astrology sign!");
            string userGuess = Console.ReadLine();
            bool guessedCorrect = userGuess == "Gemini";

            // do, switch, and while
            do
            {
                switch (userGuess)
                {
                    case "Aries": 
                        Console.WriteLine("You guessed Aries. No way.");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Taurus":
                        Console.WriteLine("You guessed Taurus. That's wrong but my brother is!");
                        Console.WriteLine("But actually guess what my astrology sign is!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Cancer":
                        Console.WriteLine("You guessed Cancer. Try again.");
                        Console.WriteLine("Guess my astrology sign, you're close!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Leo":
                        Console.WriteLine("You guessed Leo. Try again.");
                        Console.WriteLine("Are you even trying??? \nGuess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Virgo":
                        Console.WriteLine("You guessed Virgo. Negative ghost rider.");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Libra":
                        Console.WriteLine("You guessed Libra. Nope.");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Scorpio":
                        Console.WriteLine("You guessed Scorpio. You guessed... WRONG!");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Sagittarius":
                        Console.WriteLine("You guessed Sagittarius (what a weird word). Try again.");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Capricorn":
                        Console.WriteLine("You guessed Capricorn. You're getting close... NOT!");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Aquarius":
                        Console.WriteLine("You guessed Aquarius. Try again.");
                        Console.WriteLine("Try harder! What's my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Pisces":
                        Console.WriteLine("You guessed Pisces. Justin Beiber is a Pisces but I'm not!");
                        Console.WriteLine("Guess again!");
                        userGuess = Console.ReadLine();
                        break;
                    case "Gemini":
                        Console.WriteLine("You guessed Gemini. How'd you know!?");
                        guessedCorrect = true;
                        break;
                    default:
                        Console.WriteLine("...that's not even an astrology sign! -_- \nIf you need a list just ask. " +
                            "\nAries, Taurus, Gemini, Cancer, Leo, Virgo, \nLibra, Scorpio, Sagittarius, Capricorn, Aquarius, and Pisces.");
                        Console.WriteLine("Guess my astrology sign!");
                        userGuess = Console.ReadLine();
                        break;
                }
            }
            while (!guessedCorrect);

            Console.Read();
        }
    }
}
