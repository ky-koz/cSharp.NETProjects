using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill156
{
    public class Class1
    {
       

        public int Multiply(int var1)
        {
            return var1 * var1;
        }

        public int Divide(int var1)
        {
            return var1 / var1;
        }

        public int Add(int var1)
        {
            return var1 + var1;
        }
    }
}


//1. Create a class. In that class, create three methods, each of which will take one integer 
//    parameter in and return an integer.The methods should do some math operation on the 
//    received parameter.Put this class in a separate.cs file in the application.


//public Deck()
//{
//    Cards = new List<Card>();
//    List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
//    List<string> Faces = new List<string>()
//            {
//                "Two", "Three", "Four", "Five", "Six", "Seven",
//                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
//            };

//    foreach (string face in Faces)
//    {
//        foreach (string suit in Suits)
//        {
//            Card card = new Card();
//            card.Suit = suit;
//            card.Face = face;
//            Cards.Add(card);

//        }
//    }

//}
//public List<Card> Cards { get; set; }

//public class Card
//{
//    //this is a constructor in which the values are default for the class
//    public Card()
//    {
//        Suit = "Spades";
//        Face = "Two";
//    }


//    public string Suit { get; set; }
//    public string Face { get; set; }
//}