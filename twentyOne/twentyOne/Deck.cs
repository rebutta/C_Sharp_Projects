using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        //Function or Method "Shuffle"
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>(); //creating and naming new list to tempList
                Random random = new Random(); //creating and naming new Random to random

                while (Cards.Count > 0) //while deck is greater than zero it will do whats in the curly brackets
                {
                    int randomIndex = random.Next(0, Cards.Count); //created int (randomIndex) that randomly grabs a card from deck and takes that value
                    tempList.Add(Cards[randomIndex]); //places card value from randomIndex in tempList
                    Cards.RemoveAt(randomIndex); //removes card value from deck based on randomIndex
                }
                Cards = tempList; //sets deck equal to tempList
            }
        }
    }
}
