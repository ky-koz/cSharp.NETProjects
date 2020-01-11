using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill156
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do I need to create an object for the class methods to exist?

            Console.WriteLine("Choose a variable to perform math operations.");
            Console.WriteLine("Please enter a whole number: ");
            int var1= Convert. ToInt32(Console.ReadLine());
            
            //I need an object to call, a method is not an object
            Console.WriteLine(Class1.Multiply);
        }
        
    }
}

//2. In the Main() program, ask the user what number they want to do the math operations on.
//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

//class Program
//{
//    static void Main(string[] args)
//    {
//        Deck deck = new Deck();
//        deck = Shuffle(deck); //call and return new deck value from method shuffle

//        foreach (Card card in deck.Cards)
//        {
//            Console.WriteLine(card.Face + " of " + card.Suit);
//        }
//        Console.WriteLine(deck.Cards.Count);
//        Console.ReadLine();
//    }

//    //randomly remove a cards from deck and put it into a temp deck, do that until deck count is at 0
//    public static Deck Shuffle(Deck deck)
//    {
//        List<Card> TempList = new List<Card>();
//        Random random = new Random();

//        while (deck.Cards.Count > 0)
//        {
//            int randomIndex = random.Next(0, deck.Cards.Count);
//            TempList.Add(deck.Cards[randomIndex]);
//            deck.Cards.RemoveAt(randomIndex); //.removeAt is a list method
//        }
//        deck.Cards = TempList;
//        return deck;
//    }
//}