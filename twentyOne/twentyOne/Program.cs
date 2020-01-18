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
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        

    }
}

//enums
//Card card = new Card();
//int underlyingValue = (int)Suit.Diamonds; //or Convert.ToInt32
//Console.Write(underlyingValue); //underlying data type is int, auto prints off the indices at the int value, unless set(=) otherwise

//ConsoleColor color = ConsoleColor.DarkYellow;
//DaysOfTheWeek day = DaysOfTheWeek.Monday;

//public enum DaysOfTheWeek
//{
//    Monday,
//    Tuesday,
//    WEdnesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

/*-------------------*/
//Player<Card> player = new Player<Card>(); //using generics
//player.Hand = new List<Card>();

/*-------------------*/
//Game game = new TwentyOneGame(); //enabling polymorphism here again
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game += player; // same as game = game + player
//game -= player; //same as game = game - player    

/*-------------------*/
//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
//game.ListPlayers();
//Console.ReadLine();

/*-------------------*/
//List<Game> games = new List<Game>();
//Game game = new TwentyOneGame(); //polymorphism, because twentyonegame inherits from game
//games.Add(game);
//PokerGame
//SolitaireGame

/*-------------------*/
//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; //calling a superclass method
//game.ListPlayers();
//game.Play();
//Console.ReadLine();

/*-------------------*/
//Game game = new Game();
//game.Dealer = "Jesse";
//game.Name = "TwentyOne";

/*-------------------*/
//Console.WriteLine("Time shuffled: {0}", timesShuffled);

//int timesShuffled = 0; //must create the object outside of the loop
//deck = Shuffle(deck, 3); //call and return new deck value from method shuffle, tells it to shuffle three times
//deck = Shuffle(deck: deck, times: 3);
//deck = Shuffle(deck, out timesShuffled, 3);

/*-------------------*/
//This method would require adding a card one by one, instead could use a deck constructor
//deck.Cards = new List<Card>(); //deck has property of Cards, with a data type of list<card>, instantiated with new

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

/*-------------------*/

//Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

/*-------------------*/
//randomly remove a cards from deck and put it into a temp deck, do that until deck count is at 0

//public static Deck Shuffle(Deck deck, int times)
//{
//   for (int i = 0; i < times; i++)
//   {
//        deck = Shuffle(deck);
//   }
//   return deck;
//}

