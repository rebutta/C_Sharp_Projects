using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //creates object from class Deck called deck
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); //calls on method Shuffle(singular)

            foreach (Card card in deck.Cards) //foreach statment selecting each card 
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //displays each card with face and suit
            }
            Console.WriteLine(deck.Cards.Count); //displays the number of cards in the deck (52)
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }

        //Function or Method "Shuffle"
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> tempList = new List<Card>(); //creating and naming new list to tempList
                Random random = new Random(); //creating and naming new Random to random

                while (deck.Cards.Count > 0) //while deck is greater than zero it will do whats in the curly brackets
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //created int (randomIndex) that randomly grabs a card from deck and takes that value
                    tempList.Add(deck.Cards[randomIndex]); //places card value from randomIndex in tempList
                    deck.Cards.RemoveAt(randomIndex); //removes card value from deck based on randomIndex
                }
                deck.Cards = tempList; //sets deck equal to tempList
            }
            return deck; //return the deck
        }

        //public static Deck Shuffle(Deck deck, int times) //example of overload method
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
