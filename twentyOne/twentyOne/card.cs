using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public class Card
    {
        //this is a constructor in which the values are default for the class
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }


        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
