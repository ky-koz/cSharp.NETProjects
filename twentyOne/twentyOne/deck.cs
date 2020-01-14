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
            //constructor
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
        //properties
        public List<Card> Cards { get; set; }

        //method
        public void Shuffle(int times = 1) // removed: Deck deck, out int timesShuffled,
        {
            //timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                //timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex); //.removeAt is a list method
                }
                Cards = TempList; //this.Cards refers to itself
            }

        }
    }
}


//Cards = new List<Card>();
//Card cardOne = new Card();
//cardOne.Face = "Two";
//cardOne.Suit = "Hearts";
//Cards.Add(cardOne);