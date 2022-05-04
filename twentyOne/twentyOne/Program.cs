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
            
            Deck deck = new Deck();             //creates object from class Deck called deck
            deck.Shuffle(3);             //calls on method Shuffle from deck class

            foreach (Card card in deck.Cards)           //foreach statment selecting each card 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);          //displays each card with face and suit
            }
            Console.WriteLine(deck.Cards.Count);            //displays the number of cards in the deck (52)
            Console.ReadLine();


        }
    }
}
