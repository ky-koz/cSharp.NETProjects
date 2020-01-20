using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.twentyOne;

namespace twentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only.");
            }

            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C: \Users\Kyla Kozole\Desktop\Repositories\c#.NET\Logs\log.txt", true)) //log the string card, dealing with unmanaged code, have to dispose of afterwards
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }   
    }
}

//Console.WriteLine("And how much money did you bring today?");
//int bank = Convert.ToInt32(Console.ReadLine());

/*-------------------*/
//var newPlayer = new Player("Jesse"); //utilizing constructor chaining
//Guid identifier = Guid.NewGuid(); //making a new guid
/*-------------------*/
//DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
//DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

//TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

/*-------------------*/
//string text = File.ReadAllText(@"C: \Users\Kyla Kozole\Desktop\Repositories\c#.NET\Logs\log.txt"); //@ means to read the string as is, otherwise it would read as escape characters and would have to do \\
//string text = "Here is some text.";
//File.WriteAllText(@"C: \Users\Kyla Kozole\Desktop\Repositories\c#.NET\Logs\log.txt", text); 

/*-------------------*/
//Deck deck = new Deck();
//deck.Shuffle(3);
//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();


/*-------------------*/
//lambda
//List<int> numberList = new List<int>() { 1, 3, 25, 634, 41, 34 };
//int sum = numberList.Where(x => x > 20).Sum();
//int sum = numberList.Sum();
//int sum = numberList.Max();
//int sum = numberList.Min();
//int sum = numberList.Sum(x => x + 5);
//Console.WriteLine(sum);


// => is a unique lambda function operator
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //Where is similar to a SQL where to filter items
//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}

//int count = deck.Cards.Count(x => x.Face == Face.Ace); //counting all the elements(x) where(=>) x.Face equals Face.Ace
//Console.WriteLine(count);

//lambda alternative
//int counter = 0;
//foreach (Card card in deck.Cards)
//{
//    if (card.Face == Face.Ace)
//    {
//        counter++;
//    }
//}
//Console.WriteLine(counter);

//structs

//Card card1 = new Card();
//Card card2 = card1; //not a new object, a new name for it - this would not work with strings
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//Console.WriteLine(card1.Face);

/*-------------------*/
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

