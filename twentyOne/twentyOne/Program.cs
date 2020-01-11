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
            Deck deck = new Deck();
            deck = Shuffle(deck); //call and return new deck value from method shuffle

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //randomly remove a cards from deck and put it into a temp deck, do that until deck count is at 0
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex); //.removeAt is a list method
            }
            deck.Cards = TempList;
            return deck;
        }

        public static Deck Shuffle(Deck deck, int times)
        {
           for (int i = 0; i < times; i++)
           {
                deck = Shuffle(deck);
           }
           return deck;
        }
    }
}

//This method would require adding a card one by one, instead could use a deck constructor
//deck.Cards = new List<Card>(); //deck has property of Cards, with a data type of list<card>, instantiated with new

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);


//Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);